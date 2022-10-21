﻿// -------------------------------------------------------------------------------------------
// <copyright file="BaseParameter.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Reflection;
using MW5.Plugins.Interfaces;
using MW5.Tools.Controls.Parameters;
using MW5.Tools.Services;

namespace MW5.Tools.Model.Parameters
{
    /// <summary>
    /// A parameter of a GIS tool. 
    /// Usually is generated for each property of the tool marked with Input, Output attributes.
    /// </summary>
    public abstract class BaseParameter
    {
        /// <summary>
        /// Gets or sets the control.
        /// </summary>
        public ParameterControlBase Control { get; set; }

        /// <summary>
        /// Gets or sets the name of the parameter (equals to the name of property it was generated for).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the control to be displayed as a tooltip.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BaseParameter"/> is required.
        /// </summary>
        public bool Required { get; set; }
        public bool CanEmpty { get; set; }
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Gets or sets the name of the section the parameter belongs to.
        /// </summary>
        public string SectionName { get; set;}

        /// <summary>
        /// Gets or sets a value indicating whether parameter should be skipped by UI generation.
        /// </summary>
        public bool SkipUIGeneration 
        {
            get { return Index == -1; } 
        }

        /// <summary>
        /// Gets or sets a value indicating whether this parameter is input one.
        /// </summary>
        public bool IsInput { get; set; }

        /// <summary>
        /// Gets or sets the default value of the parameter.
        /// </summary>
        public object DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets property of the GisTool class, current parameter is generated for.
        /// </summary>
        public PropertyInfo ToolProperty { get; set; }

        /// <summary>
        /// Gets or sets the tool the parameter was generated for.
        /// </summary>
        public IGisTool Tool { get; set; }

        /// <summary>
        /// Gets or sets value restored from config from previous run of the tool.
        /// </summary>
        public object PreviousValue { get; set; }

        /// <summary>
        /// Gets the initial value of the control. It's either DefaultValue or PreviousValue.
        /// </summary>
        public object InitialValue
        {
            get
            {
                if (PreviousValue != null)
                {
                    return PreviousValue;
                }

                return DefaultValue;
            }
        }

        /// <summary>
        /// Gets the value of the parameter. It's value set in the control if control is attached, or 
        /// the value of the relevant property of the tool class otherwise.
        /// </summary>
        public virtual object Value
        {
            get
            {
                if (Control != null)
                {
                    return Control.GetValue();
                }

                // use tool property directly if there is no control associated with parameter
                // in such manner we can still use parameters for validation
                // if even if standard autogenerated UI isn't used
                return ToolProperty.GetValue(Tool);
            }
            set
            {
                if (Control != null)
                {
                    Control.SetValue(value);
                }

                // use tool property directly if there is no control associated with parameter
                // in such manner we can still use parameters for validation
                // if even if standard autogenerated UI isn't used
                //ToolProperty.SetValue(Tool, value);
            }
        }

        /// <summary>
        /// Gets a value indicating whether parameter has a value.
        /// </summary>
        public virtual bool IsEmpty
        {
            get { return false; }
        }

        /// <summary>
        /// Sets new value to the property of the tool class associated with the current parameter.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetToolValue(object value)
        {
            dynamic val = null;
            switch (value)
            {
                case MW5.UI.Helpers.ComboBoxEnumItem<Api.Enums.ClipOperation> item:
                    val = item.GetValue();
                    break;
                case MW5.UI.Helpers.ComboBoxEnumItem<Api.Enums.AreaUnits> item:
                    val = item.GetValue();
                    break;
                case MW5.UI.Helpers.ComboBoxEnumItem<Api.Enums.GroupOperation> item:
                    val = item.GetValue();
                    break;
                case MW5.UI.Helpers.ComboBoxEnumItem<Api.Enums.SpatialRelation> item:
                    val = item.GetValue();
                    break;
                case MW5.UI.Helpers.ComboBoxEnumItem<Api.Enums.SelectionOperation> item:
                    val = item.GetValue();
                    break;
                case MW5.UI.Helpers.ComboBoxEnumItem<MW5.Api.Enums.TopologyRule> item:
                    val = item.GetValue();
                    break;
                case MW5.UI.Helpers.ComboBoxEnumItem<MW5.Tools.Enums.PolygonCenter> item:
                    val = item.GetValue();
                    break;
                default:
                    val = value;
                    break;
            }
            ToolProperty.SetValue(Tool, val);
        }

        /// <summary>
        /// Gets a value indicating whether the parameter should be serialized into config file 
        /// to preserve the last used value.
        /// </summary>
        public virtual bool Serializable
        {
            get { return false; }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        public override string ToString()
        {
            var val = Value;
            var s = val != null ? val.ToString() : string.Empty;
            return string.Format("{0}: {1}", DisplayName, s);
        }

        public ControlHintAttribute ControlHint { get; set; }
    }
}