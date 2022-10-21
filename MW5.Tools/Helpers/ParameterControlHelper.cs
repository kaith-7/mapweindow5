﻿// -------------------------------------------------------------------------------------------
// <copyright file="ParameterControlHelper.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using MW5.Tools.Controls.Parameters;
using MW5.Tools.Controls.Parameters.Input;

namespace MW5.Tools.Helpers
{
    /// <summary>
    /// Extension method to work with parameter controls.
    /// </summary>
    internal static class ParameterControlHelper
    {
        /// <summary>
        /// Sets caption to the control, also removing trailing colon.
        /// </summary>
        public static void SetCaption(this ParameterControlBase ctrl, string caption)
        {
            ctrl.Caption = caption;

            if (ctrl is BooleanParameterControl)
            {
                // do nothing
            }
            else
            {
                if (!ctrl.Caption.Trim().EndsWith(":"))
                {
                    ctrl.Caption += ":";
                }
            }
        }

        public static void SetDefaultSelectIndex(this ParameterControlBase ctrl, int defaultSelectedIndex = 0)
        {
            if (ctrl is LayerParameterControl layerControl)
            {
                layerControl.DefaultSelectedIndex = defaultSelectedIndex;
            }
        }
    }
}