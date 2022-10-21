// -------------------------------------------------------------------------------------------
// <copyright file="UpdateMeasurementsPresenter.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Attributes.Helpers;
using MW5.Plugins.Helpers;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mvp;
using MW5.Plugins.Services;
using MW5.Plugins.TableEditor.Helpers;
using MW5.Plugins.TableEditor.Model;
using MW5.Plugins.TableEditor.Views.Abstract;
using MW5.Shared;

namespace MW5.Plugins.TableEditor.Views
{
    public class UpdateMeasurementsPresenter : BasePresenter<IUpdateMeasurementsView, IFeatureSet>
    {
        private readonly IAppContext _context;
        private MeasurementInfo _areaInfo;
        private MeasurementInfo _lengthInfo;

        public UpdateMeasurementsPresenter(IUpdateMeasurementsView view, IAppContext context)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        public override bool ViewOkClicked()
        {
            _areaInfo = View.AreaInfo;
            _lengthInfo = View.LengthInfo;

            if (!Validate())
            {
                return false;
            }

            if (!CreateField(_lengthInfo))
            {
                return false;
            }

            if (!CreateField(_areaInfo))
            {
                return false;
            }

            Calculate();

            return true;
        }

        private void Calculate()
        {
            var map = _context.Map;
            var table = Model.Table;

            const string msg = "Updating measurements";
            GlobalListeners.ReportProgress(string.Empty, 0, msg);
            int featureCount = Model.Features.Count;

            foreach (var ft in Model.Features)
            {
                GlobalListeners.ReportProgress(string.Empty, Convert.ToInt32((ft.Index + 1) * 100.0 / featureCount), msg);

                var g = ft.Geometry;

                if (_lengthInfo.Active)
                {
                    double length = map.GeodesicLength(g);

                    length = UnitConversionHelper.Convert(LengthUnits.Meters, View.LengthUnits, length);

                    table.EditCellValue(_lengthInfo.FieldIndex, ft.Index, length);
                }

                if (_areaInfo.Active)
                {
                    double area = map.GeodesicArea(g);

                    area = UnitConversionHelper.Convert(AreaUnits.SquareMeters, View.AreaUnits, area);

                    table.EditCellValue(_areaInfo.FieldIndex, ft.Index, area);
                }
            }

            GlobalListeners.ClearProgress();
        }

        private bool CreateField(MeasurementInfo info)
        {
            if (info.Type == UpdateMeasurementType.NewField)
            {
                info.FieldIndex = Model.Table.Fields.Add(info.Name, AttributeType.Double, info.Precision, info.Width);
                if (info.FieldIndex == -1)
                {
                    MessageService.Current.Info("创建字段失败。");
                    return false;
                }
            }

            return true;
        }

        private bool TryOverwriteField(MeasurementInfo item)
        {
            var fields = Model.Table.Fields;

            if (Model.Table.Fields.Any(f => f.Name.ContainsIgnoreCase(item.Name)))
            {
                if (
                    !MessageService.Current.Ask(
                        "字段名已存在: " + item.Name + Environment.NewLine + "覆盖?"))
                {
                    return false;
                }

                int index = fields.IndexByName(item.Name);
                if (!fields.Remove(index))
                {
                    MessageService.Current.Info("删除字段失败: " + item.Name);
                }
            }

            return true;
        }

        private bool Validate()
        {
            if (_areaInfo.Type == UpdateMeasurementType.Ignore && _lengthInfo.Type == UpdateMeasurementType.Ignore)
            {
                MessageService.Current.Info("无效的计算条,请选择长度或面积。");
                return false;
            }

            var list = new List<MeasurementInfo> { _lengthInfo, _areaInfo };

            foreach (var item in list)
            {
                switch (item.Type)
                {
                    case UpdateMeasurementType.Ignore:
                        continue;
                    case UpdateMeasurementType.ExistingField:
                        if (item.FieldIndex == -1)
                        {
                            MessageService.Current.Info(
                                "表中没有适合写入的字段 " + item.DefaultName + "." +
                                 Environment.NewLine + "请创建一个新字段。");
                            return false;
                        }
                        break;
                    case UpdateMeasurementType.NewField:
                        {
                            string err;
                            if (!Model.Table.ValidateFieldNameSlack(item.Name, out err))
                            {
                                MessageService.Current.Info(err);
                                return false;
                            }

                            if (!TryOverwriteField(item))
                            {
                                return false;
                            }
                        }
                        break;
                }
            }

            return true;
        }
    }
}