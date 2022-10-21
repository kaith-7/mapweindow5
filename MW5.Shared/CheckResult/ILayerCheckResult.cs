// -------------------------------------------------------------------------------------------
// <copyright file="ILogEntry.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Drawing;

namespace MW5.Shared.CheckResult
{
    public interface ILayerCheckResult
    {
        [DisplayName(" ")]
        int LayerHandle { get; set; }
        [DisplayName("要素id")]
        int FeatureIndex { get; set; }
        [DisplayName("错误信息")]
        string ErrorMessage { get; set; }
    }

    public interface ITopologyCheckResult
    {
        [DisplayName("错误类型")]
        string ErrorType { get; set; }
        [DisplayName("层1")]
        string LayerName { get; set; }
        [DisplayName("要素id1")]
        int FeatureIndex { get; set; }

        [DisplayName("层2")]
        string LayerName2 { get; set; }
        [DisplayName("要素id2")]
        int FeatureIndex2 { get; set; }

        [DisplayName("检查规则")]
        string Rule { get; set; }

        //IGeometry geomErr { get; set; }
    }
}