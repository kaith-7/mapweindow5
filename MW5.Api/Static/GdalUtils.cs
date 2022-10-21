// -------------------------------------------------------------------------------------------
// <copyright file="GdalUtils.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ExcelDataReader;
using MapWinGIS;
using MW5.Api.Concrete;
using MW5.Api.Interfaces;
using MW5.Shared.Log;

namespace MW5.Api.Static
{
    public class GdalUtils
    {
        private static readonly GdalUtils _staticUtils = new GdalUtils();
        private readonly Utils _utils = new Utils();
        private readonly MapWinGIS.GdalUtils _mwgisGdalUtils = new MapWinGIS.GdalUtils();
        private string _lastErrorMessage;

        public IGlobalListener Callback
        {
            get { return NativeCallback.UnWrap(_utils.GlobalCallback); }
            set
            {
                var callback = NativeCallback.Wrap(value);
                _utils.GlobalCallback = callback;

                // TODO: Use with _mwgisGdalUtils as well

                // TODO: implement
                //_utils.StopExecution = callback;
            }
        }

        /// <summary>
        /// instance of MapWinGIS.Utils class. 
        /// Use whenever there is no need to share callback in multithreading scenario.
        /// </summary>
        public static GdalUtils Instance
        {
            get { return _staticUtils; }
        }

        public bool GdalAddOverviews(string bstrSrcFilename, string bstrOptions, string bstrLevels)
        {
            return _utils.GDALAddOverviews(bstrSrcFilename, bstrOptions, bstrLevels);
        }

        public bool GdalBuildVrt(string bstrDstFilename, string bstrOptions)
        {
            return _utils.GDALBuildVrt(bstrDstFilename, bstrOptions);
        }

        public string GdalInfo(string srcFilename, string bstrOptions)
        {
            return _utils.GDALInfo(srcFilename, bstrOptions);
        }

        public bool GdalRasterize(string bstrSrcFilename, string bstrDstFilename, string bstrOptions)
        {
            return _utils.GDALRasterize(bstrSrcFilename, bstrDstFilename, bstrOptions);
        }

        public bool Ogr2Ogr(string bstrSrcFilename, string bstrDstFilename, string bstrOptions)
        {
            return _utils.OGR2OGR(bstrSrcFilename, bstrDstFilename, bstrOptions);
        }

        public string OgrInfo(string bstrSrcFilename, string bstrOptions, string bstrLayers)
        {
            return _utils.OGRInfo(bstrSrcFilename, bstrOptions, bstrLayers);
        }

        public bool TranslateRaster(string srcFilename, string dstFilename, string bstrOptions)
        {
            //return _utils.TranslateRaster(srcFilename, dstFilename, bstrOptions);
            var options = bstrOptions.Trim().Split(new char[] { ' ' }, options:StringSplitOptions.RemoveEmptyEntries);
            return _mwgisGdalUtils.GdalRasterTranslate(srcFilename, dstFilename, options);
        }

        [Obsolete("Use WarpRaster(string srcFilename, string dstFilename, string[] options)")]
        public bool WarpRaster(string srcFilename, string dstFilename, ISpatialReference newProjection)
        {
            string options = string.Format("-t_srs \"{0}\"", newProjection.ExportToProj4());
            return _utils.GDALWarp(srcFilename, dstFilename, options);
        }

        [Obsolete("Use WarpRaster(string srcFilename, string dstFilename, string[] options)")]
        public bool WarpRaster(string srcFilename, string dstFilename, string options)
        {
            var retVal = _utils.GDALWarp(srcFilename, dstFilename, options);
            if (!retVal)
            {
                _lastErrorMessage = _utils.ErrorMsg[_utils.LastErrorCode];
            }

            return retVal;
        }

        /// <summary>
        /// Warps the raster. Using Gdal.GDALWarp (available since GDALv2)
        /// </summary>
        /// <param name="srcFilename">The source filename.</param>
        /// <param name="dstFilename">The DST filename.</param>
        /// <param name="options">The options. See http://www.gdal.org/gdalwarp.html for the possible options.</param>
        /// <returns>True on success</returns>
        public bool VectorTranslate(string srcFilename, string dstFilename, string[] options)
        {
            var retVal = _mwgisGdalUtils.GdalVectorTranslate(srcFilename, dstFilename, options);
            if (!retVal)
            {
                _lastErrorMessage = _mwgisGdalUtils.ErrorMsg[_mwgisGdalUtils.LastErrorCode];
            }

            return retVal;
        }

        /// <summary>
        /// Warps the raster. Using Gdal.GDALWarp (available since GDALv2)
        /// </summary>
        /// <param name="srcFilename">The source filename.</param>
        /// <param name="dstFilename">The DST filename.</param>
        /// <param name="options">The options. See http://www.gdal.org/gdalwarp.html for the possible options.</param>
        /// <returns>True on success</returns>
        public bool WarpRaster(string srcFilename, string dstFilename, string[] options)
        {
            var retVal = _mwgisGdalUtils.GdalRasterWarp(srcFilename, dstFilename, options);
            if (!retVal)
            {
                _lastErrorMessage = _mwgisGdalUtils.ErrorMsg[_mwgisGdalUtils.LastErrorCode];
            }

            return retVal;
        }

        public string LastErrorMessage()
        {
            return _lastErrorMessage;
        }

        //转换为点shp文件
        public bool ConvertPoint(DataTable table, string saveFile, string xColName, string yColName)
        {
            long LastLineNumber = 0;
            try
            {
                var FieldIndices = new Hashtable();
                var FieldRenames = new Hashtable();

                MapWinGIS.ShpfileType sftype;
                sftype = MapWinGIS.ShpfileType.SHP_POINT;

                MapWinGIS.Shapefile newSF = new MapWinGIS.Shapefile();
                newSF.CreateNew(saveFile, sftype);
                newSF.StartEditingShapes(true);

                MapWinGIS.Field idFld = new MapWinGIS.Field();
                idFld.Key = "MWShapeID";
                idFld.name = "MWShapeID";
                idFld.Precision = 10;
                idFld.Type = MapWinGIS.FieldType.INTEGER_FIELD;
                int fldIdx = newSF.NumFields;
                newSF.EditInsertField(idFld, fldIdx);
                FieldIndices.Add("MWShapeID", fldIdx);

                foreach (DataRow Vals in table.Rows)
                {
                    LastLineNumber += 1;

                    Application.DoEvents();

                    //string[] Vals = line.Split(cmbDelim.Text.ToCharArray()[0]);

                    DataRow dataRow = Vals;

                    // ConditionValues(ref dataRow);

                    MapWinGIS.Shape newShp = new MapWinGIS.Shape();
                    newShp.Create(sftype);

                    MapWinGIS.Point newPt = new MapWinGIS.Point();
                    //获取
                    for (int i = 0; i <= table.Columns.Count - 1; i++)
                    {
                        string colName = table.Columns[i].ColumnName;
                        double coo = GetCoordinates(Vals[i].ToString());
                        if (coo == -1) return false;
                        Vals[i] = coo;//将单元格值转化为数字格式
                        if (colName == xColName)
                        {
                            newPt.x = coo;
                        }
                        else if (colName == yColName)
                        {
                            newPt.y = coo;
                        }
                        //else if (colName == cmbM.Text && colName != "")
                        //{
                        //    newPt.Z = coo;
                        //}
                        //else if (colName == cmbZ.Text && colName != "")
                        //{
                        //    newPt.M = coo;
                        //}
                    }

                    newShp.InsertPoint(newPt, 0);
                    int shpIdx = newSF.NumShapes;
                    newSF.EditInsertShape(newShp, ref shpIdx);

                    if (newSF.LastErrorCode != 0 && newSF.ErrorMsg[newSF.LastErrorCode] != "No Error")
                    {
                        MessageBox.Show(newSF.ErrorMsg[newSF.LastErrorCode]);
                        return false;
                    }

                    //若表中包含filed对应列名
                    for (int i = 0; i <= table.Columns.Count - 1; i++)
                    {
                        string colName = table.Columns[i].ColumnName;
                        // Always edit the fields for the x, y, z, m
                        // values regardless of value of chkAttribs 
                        if (colName != "" && FieldRenames.Contains(i))
                            newSF.EditCellValue((int)FieldRenames[i], shpIdx, Vals[i]);
                        else if (colName != "" && FieldIndices.Contains(colName))
                            newSF.EditCellValue((int)FieldIndices[colName], shpIdx, Vals[i]);
                    }

                    //  newShp = null/* TODO Change to default(_) if this is not a reference type */;
                    // newPt = null/* TODO Change to default(_) if this is not a reference type */;
                    // GC.Collect();

                }
                // tr.Close();

                newSF.StopEditingShapes(true, true);
                newSF.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //坐标由字符串转化为数字
        private double GetCoordinates(string coordinates)
        {
            double coo = 0;
            if (double.TryParse(coordinates, out coo))
            {
                return coo;
            }

            char[] array = coordinates.ToCharArray();
            var byteArray = Encoding.ASCII.GetBytes(array);
            List<char> list = new List<char>();
            for (int i = 0; i < byteArray.Length; i++)
            {
                int item = byteArray[i];
                if ((item < 48 || item > 57) && item !=45)
                {
                    list.Add(array[i]);
                }
            }

            var cooArray = coordinates.Split(list.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            double temp = 0;
            //换算
            for (int i = 0; i < cooArray.Length; i++)
            {
                if (!double.TryParse(cooArray[i], out temp))
                {
                    MessageBox.Show("存在格式不正确的数据", "提示");
                    return -1;
                }

                if (i == 0)
                {
                    coo += temp;
                }
                else if (i == 1)
                {
                    coo += temp / 60.0;
                }
                else if (i == 2)
                {
                    coo += temp / 3600.0;
                }
            }
            // return Math.Round(coo, 4);
            return coo;
        }
        //将csv文件读取为datatable
        public DataTable GetTableFromFile(string fileName)
        {
            //1：打开文件，得到文件stream
            var streamData = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //2：得到文件reader（需要NuGet包ExcelDataReader）

            var readerData = ExcelReaderFactory.CreateOpenXmlReader(streamData);
            //3：通过reader得到数据（需要NuGet包ExcelDataReader.DataSet ）
            ExcelDataReader.ExcelDataSetConfiguration setConfig = new ExcelDataSetConfiguration();
            var result = readerData.AsDataSet();
            //4：得到ExcelFile文件的表Sheet
            var dataTable = result.Tables[0];

            for (int i = 0; i <= dataTable.Columns.Count - 1; i++)
            {
                if (!string.IsNullOrEmpty(dataTable.Columns[i].ToString()))
                    dataTable.Columns[i].ColumnName = dataTable.Rows[0][i].ToString();
            }
            dataTable.Rows.RemoveAt(0);
            return dataTable;
        }

    }
}