// -------------------------------------------------------------------------------------------
// <copyright file="DbfImportHelper.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Interfaces;
using MW5.Plugins.Services;
using MW5.Shared;

namespace MW5.Attributes.Helpers
{
    /// <summary>
    /// The dbf import.
    /// </summary>
    public static class DbfImportHelper
    {
        /// <summary>
        /// Fills table with data obtained by ADO.NET provider
        /// </summary>
        /// <param name="dt"> Data table to make the data from </param>
        /// <param name="tableToFill"> MapWinGIS table to copy the data to </param>
        public static void FillMapWinGisTable(DataTable dt, IAttributeTable tableToFill)
        {
            tableToFill.CreateNew(string.Empty);

            CopyFields(dt, tableToFill);

            CopyValues(dt, tableToFill);
        }

        /// <summary>
        /// Import field definitions.
        /// </summary>
        public static bool ImportFieldsFromDbf(IFileDialogService service, IAttributeTable table)
        {
            if (service == null) throw new ArgumentNullException("service");

            if (!table.EditMode)
            {
                return false;
            }

            string filename;

            service.Title = @"请选择要导入的DBF文件...";

            if (!service.Open(@"DBF Files (*.dbf)|*.dbf", out filename))
            {
                return false;
            }

            using (var impTable = new AttributeTable())
            {
                if (!impTable.Open(filename))
                {
                    const string err = "打开失败。";
                    Logger.Current.Info(err + " 文件名: " + impTable.LastError);
                    MessageService.Current.Info(err);
                    return false;
                }

                string msg = "即将导入字段: " + impTable.Fields.Count + "." + Environment.NewLine
                             + "继续?";

                if (!MessageService.Current.Ask(msg))
                {
                    return false;
                }

                var skipped = new List<string>();
                int count = 0;

                var fields = table.Fields;
                foreach (var fld in impTable.Fields)
                {
                    count++;

                    if (fields.IndexByName(fld.Name) == -1)
                    {
                        table.Fields.Add(fld.Name, fld.Type, fld.Precision, fld.Width);
                    }
                    else
                    {
                        skipped.Add(fld.Name);
                    }
                }

                msg = "Field definitions imported: " + count + ".";

                if (skipped.Any())
                {
                    msg += Environment.NewLine + Environment.NewLine;
                    msg += "由于字段名冲突，以下字段跳过: ";
                    msg += Environment.NewLine + StringHelper.Join(skipped, ",");
                }

                MessageService.Current.Info(msg);
            }

            return true;
        }

        private static void CopyFields(DataTable dt, IAttributeTable tableToFill)
        {
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                var type = AttributeType.String;

                switch (dt.Columns[i].DataType.ToString())
                {
                    case "System.String":
                        type = AttributeType.String;
                        break;
                    case "System.Double":
                        type = AttributeType.Double;
                        break;
                    case "System.Int32":
                        type = AttributeType.Integer;
                        break;
                    case "System.DateTime":
                        type = AttributeType.Date;
                        break;
                    case "System.Boolean":
                        type = AttributeType.Boolean;
                        break;
                }
                var fld = new AttributeField { Name = dt.Columns[i].ColumnName, Type = type, Precision = 6, };

                if (dt.Columns[i].MaxLength != -1)
                {
                    fld.Width = dt.Columns[i].MaxLength;
                }

                tableToFill.Fields.Add(fld);
            }
        }

        private static void CopyValues(DataTable dt, IAttributeTable tableToFill)
        {
            for (var j = 0; j < dt.Rows.Count; j++)
            {
                var index = tableToFill.NumRows;
                if (tableToFill.EditInsertRow(ref index))
                {
                    for (var i = 0; i < dt.Columns.Count; i++)
                    {
                        tableToFill.EditCellValue(i, index, dt.Rows[j][i]);
                    }
                }
            }
        }
    }
}