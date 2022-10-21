using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Ionic.Zip;
using MW5.Api.Interfaces;
using MW5.Plugins.Concrete;
using MW5.Plugins.Enums;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Services;
using MW5.Tools.Model;
using MW5.Tools.Model.Layers;
using MW5.Api.Legend;
using MW5.Api.Legend.Abstract;
using MW5.Shared;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Xml.Linq;
using System.Xml;

namespace MW5.Tools.Tools.AdditionalTools
{
    [GisTool(GroupKeys.AdditionalTools, Enums.ToolIcon.ToolDefault)]
    public class PublishToGeoserver : GisTool
    {

        public LegendControl publishlegend = LegendGroups.publishlegend;

        //public readonly LegendControl _legend = LegendControl.pushthis();

        [Input("服务名称", 0)]
        public string MapserverName { get; set; }

        [Input("数据组名", 0, true), DefaultValue("")]
        public string GroupNmae { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "地图发布"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "将当前图层样式写入.sld文件，发布到Geoserver。"; }
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// Gets a value indicating whether the tool supports batch execution.
        /// </summary>
        public override bool SupportsBatchExecution => false;

        /// <summary>
        /// Runs the tool.
        /// </summary>
        /// 
        public override bool Run(ITaskHandle task)
        {
            //解析当前工程的所有图层
            int groupsum = publishlegend.Groups.Count; //图层组数量
            if (groupsum == 0)
            {
                MessageService.Current.Info("无数据!!!");
                return false;
            }

            string alllayerstring = ""; //传入接口的图层顺序字符串参数

            //循环解析每一个图层
            int groupfristLayer = 0;
            string zippath = "";
            for (int groupi = 0; groupi < groupsum; groupi++)
            {
                var groupandlayer = publishlegend.Groups.GroupByLayerHandle(groupfristLayer);//得到所有图层组和图层的信息
                var layersum = groupandlayer.Layers.Count;//图层组内图层数量
                for (int layeri = 0; layeri < layersum; layeri++)
                {
                    groupfristLayer = groupfristLayer + 1;

                    string shpfilepath = groupandlayer.Layers[layeri].Filename;
                    DirectoryInfo pathInfo = new DirectoryInfo(shpfilepath);
                    string allfilePath = pathInfo.Parent.FullName;  //shp文件所在目录
                    string shpfilename = Path.GetFileNameWithoutExtension(shpfilepath);  //shp文件名

                    alllayerstring = alllayerstring + shpfilename + ","; //更新图层顺序字符串参数

                    //shp样式转存sld文件
                    string shpgeometry = groupandlayer.Layers[layeri].FeatureSet.GeometryType.ToString(); //获取shp类型
                    string sldfilepath = allfilePath + "\\" + shpfilename + ".sld";
                    switch (shpgeometry)
                    {
                        case "Polygon":
                            PolygonToSld(sldfilepath, groupandlayer.Layers[layeri].LayerSource);
                            break;
                        case "Polyline":
                            PolylineToSld(sldfilepath, groupandlayer.Layers[layeri].LayerSource);
                            break;
                        case "Point":
                            PointToSld(sldfilepath, groupandlayer.Layers[layeri].LayerSource);
                            break;
                    }
                    // 替换非法字段
                    ///去掉非法命名空间字符
                    FileStream fs = new FileStream(sldfilepath, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    string xmlstr = sr.ReadToEnd();
                    int lenxmlstr = xmlstr.Length - 181;
                    string newxmlstr = xmlstr.Substring(0, 153) + xmlstr.Substring(181, lenxmlstr);
                    sr.Close();
                    fs.Close();
                    File.Delete(sldfilepath); //删除旧文件
                    FileStream fs2 = new FileStream(sldfilepath, FileMode.Create);
                    StreamWriter sww = new StreamWriter(fs2, new UTF8Encoding(false));
                    ///修改xml头信息中编码为gbk
                    //newxmlstr = newxmlstr.Replace("StyledLayerDescriptor.xsd", "http://schemas.opengis.net/sld/1.1.0/StyledLayerDescriptor.xsd");
                    newxmlstr = newxmlstr.Replace("utf-8", "gbk");

                    sww.WriteLine(newxmlstr);
                    sww.Close();
                    fs2.Close();
                    //获取路径下所有同名文件
                    ArrayList filenameArray = new ArrayList();
                    string[] fileNames = Directory.GetFiles(allfilePath);

                    foreach (string afileName in fileNames)
                    {
                        string afterfilename = Path.GetFileNameWithoutExtension(afileName);
                        if (afterfilename.Equals(shpfilename) && afileName.Substring(afileName.Length - 4, 4) != ".zip")
                        {
                            filenameArray.Add(Path.GetFileName(afileName));
                        }
                    }
                    //打压缩包
                    if (groupfristLayer == 1)
                    {
                        string zipname = shpfilename + ".zip";
                        zippath = allfilePath + "\\" + zipname;
                        File.Delete(zippath);  //删除同名压缩包

                        using (ZipFile zipfile = new ZipFile(zippath, Encoding.UTF8))
                        {
                            foreach (string inzipfile in filenameArray)
                            {
                                zipfile.AddFile(allfilePath + "\\" + inzipfile, "");
                            }
                            zipfile.Save();
                        }
                    }
                    else
                    {
                        using (ZipFile zipfile = new ZipFile(zippath, Encoding.UTF8))
                        {
                            foreach (string inzipfile in filenameArray)
                            {
                                zipfile.AddFile(allfilePath + "\\" + inzipfile, "");
                                zipfile.Save();
                            }
                        }

                    }
                }
            }

            //压缩包上传post接口
            FileStream fileStream = new FileStream(zippath, FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);
            fileStream.Close();
            Stream zipstream = new MemoryStream(bytes);

            HttpClient _httpClient = new HttpClient();
            var postContent = new MultipartFormDataContent();

            string boundary = string.Format("--{0}", DateTime.Now.Ticks.ToString("x"));
            postContent.Headers.Add("ContentType", $"multipart/form-data, boundary={boundary}");
            var requestUrl = "http://192.168.1.72:8191/iserver/api/publish/shapefile";

            postContent.Add(new StreamContent(zipstream, (int)zipstream.Length), "zipfile", zippath);
            postContent.Add(new StringContent(MapserverName), "workspace");
            postContent.Add(new StringContent(alllayerstring.Substring(0, alllayerstring.Length - 1)), "layerOrder");
            postContent.Add(new StringContent(GroupNmae), "groupName");

            try
            {
                var response = _httpClient.PostAsync(requestUrl, postContent);
                var result = response.Result.Content.ReadAsStringAsync();

                JObject jo = JObject.Parse(result.Result);

                if (jo["code"].ToString() == "0")
                {
                    Log.Info("发布成功！！！");
                    return true;
                }
                else
                {
                    Log.Info("发布失败！！！", jo["message"].ToString());
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Warn("请检查地图发布接口！！！", ex);
                return false;
            }
        }

        /// <summary>
        /// 面shp样式转化为SLD文件
        /// </summary>
        private void PolygonToSld(string sldxmlpath, ILayerSource layersinfo)
        {
            IFeatureSet Publishlayers = (IFeatureSet)layersinfo;
            // 从图层属性中，读取写入sld文件需要用的参数
            string layername = Publishlayers.Name; //图层名称

            string oldfillcolor = Publishlayers.Style.Fill.Color.Name.ToString();
            string polygonfillcolor = "#" + oldfillcolor.Substring(2, 6); //面填充颜色

            string polygonfillopacity = Math.Round(Convert.ToDouble(Publishlayers.Style.Fill.Transparency) / 255, 2).ToString();  //填充颜色透明度

            string oldlinecolor = Publishlayers.Style.Line.Color.Name.ToString();
            string polygonlinecolor = "#" + oldlinecolor.Substring(2, 6);  //边界颜色

            string polygonlineopacity = Math.Round(Convert.ToDouble(Publishlayers.Style.Line.Transparency) / 255, 2).ToString();  //边界颜色透明度

            string polygonlinewidth = Math.Round(Publishlayers.Style.Line.Width, 2).ToString();  //边界线宽

            string oldpolygonlinestyle = Publishlayers.Style.Line.DashStyle.ToString();  //边界线形, 需要加switch

            string polygonlinestyle = "";
            switch (oldpolygonlinestyle)
            {
                case "Solid":
                    polygonlinestyle = "";
                    break;
                case "Dash":
                    polygonlinestyle = "5 2";
                    break;
                case "Dot":
                    polygonlinestyle = "1 2";
                    break;
                case "DashDot":
                    polygonlinestyle = "4 2 1 2";
                    break;
                case "DashDotDot":
                    polygonlinestyle = "4 2 1 2 1 2";
                    break;
            }


            string oldlablecolor = Publishlayers.Labels.Style.FontColor.Name.ToString();
            string lablecolor = "#" + oldlablecolor.Substring(2, 6); //标注颜色

            string lablefont = "SimSun"; //Publishlayers.Labels.Style.FontName.ToString(); //标注字体

            string lablesize = Publishlayers.Labels.Style.FontSize.ToString(); //标注字体大小

            string oldlablestyle = Publishlayers.Labels.Style.FontItalic.ToString(); //标注字体是否斜体, true/false, 需要加switch
            string lablestyle = "normal";
            switch (oldlablestyle)
            {
                case "True":
                    lablestyle = "italic";
                    break;
                case "False":
                    lablestyle = "normal";
                    break;
            }
            string oldlablebold = Publishlayers.Labels.Style.FontBold.ToString(); //标注字体是否加粗, true/false, 需要加switch
            string lablebold = "normal";
            switch (oldlablebold)
            {
                case "True":
                    lablebold = "bold";
                    break;
                case "False":
                    lablebold = "normal";
                    break;
            }
            string lableunderline = Publishlayers.Labels.Style.FontUnderline.ToString(); //标注字体是否下划线, true/false
            string lablestrikeout = Publishlayers.Labels.Style.FontStrikeOut.ToString(); //标注字体是否删除线, true/false

            string lableopacity = Math.Round(Convert.ToDouble(Publishlayers.Labels.Style.FontTransparency) / 255, 2).ToString();  //标注透明度

            string lablefield = Publishlayers.Labels.Expression;  //标注的属性字段名称，需要将表达式处理为字段列表
            string lablefieldname = "";
            if (lablefield != "")
            {
                lablefieldname = lablefield.Substring(1, lablefield.Length - 2); //暂时只支持标注一个属性字段
            }

            string Offsetlocation = Publishlayers.Labels.Style.Alignment.ToString();  //标注锚点位置,需要加switch计算对应的X,Y
            string OffsetX = "0.5";
            string OffsetY = "0.5";
            switch (Offsetlocation)
            {
                case "TopLeft":
                    OffsetX = "0";
                    OffsetY = "1";
                    break;
                case "TopCenter":
                    OffsetX = "0.5";
                    OffsetY = "1";
                    break;
                case "TopRight":
                    OffsetX = "1";
                    OffsetY = "1";
                    break;
                case "CenterLeft":
                    OffsetX = "0";
                    OffsetY = "0.5";
                    break;
                case "Center":
                    OffsetX = "0.5";
                    OffsetY = "0.5";
                    break;
                case "CenterRight":
                    OffsetX = "1";
                    OffsetY = "0.5";
                    break;
                case "BottomLeft":
                    OffsetX = "0";
                    OffsetY = "0";
                    break;
                case "BottomCenter":
                    OffsetX = "0.5";
                    OffsetY = "0";
                    break;
                case "BottomRight":
                    OffsetX = "1";
                    OffsetY = "0";
                    break;
            }
            string maxdisplayment = Publishlayers.Labels.CollisionBuffer.ToString();  //标注最大偏移量

            /// 参数读取完毕
            /// 写入sld文件


            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null)); //定义编码和版本


            XmlElement e1 = xmlDoc.CreateElement("StyledLayerDescriptor", "http://www.opengis.net/sld");

            XmlAttribute e1version1 = xmlDoc.CreateAttribute("version"); //定义命名空间
            e1version1.Value = "1.0.0";
            e1.Attributes.Append(e1version1);

            XmlAttribute e1version2 = xmlDoc.CreateAttribute("xsi", "schemaLocation", "http://www.w3.org/2001/XMLSchema-instance");
            e1version2.Value = "http://www.opengis.net/sld StyledLayerDescriptor.xsd";
            e1.Attributes.Append(e1version2);


            XmlAttribute e1version3 = xmlDoc.CreateAttribute("ogc", "xmlns", "http://www.opengis.net/ogc");
            e1.Attributes.Append(e1version3);
            XmlAttribute e1version4 = xmlDoc.CreateAttribute("xlink", "xmlns", "http://www.w3.org/1999/xlink");
            e1.Attributes.Append(e1version4);

            xmlDoc.AppendChild(e1);


            var e2 = xmlDoc.CreateElement("NamedLayer", "http://www.opengis.net/sld"); //定义第二层
            e1.AppendChild(e2);
            var e1version21 = xmlDoc.CreateElement("Name", "http://www.opengis.net/sld"); //定义图层名称
            e1version21.InnerText = layername;
            e2.AppendChild(e1version21);


            var e3 = xmlDoc.CreateElement("UserStyle", "http://www.opengis.net/sld"); //定义第三层
            e2.AppendChild(e3);
            var e1version31 = xmlDoc.CreateElement("Name", "http://www.opengis.net/sld"); //定义图层名称
            e1version31.InnerText = layername;
            e3.AppendChild(e1version31);


            var e4 = xmlDoc.CreateElement("FeatureTypeStyle", "http://www.opengis.net/sld"); //定义第四层
            e3.AppendChild(e4);


            var e51 = xmlDoc.CreateElement("Rule", "http://www.opengis.net/sld"); //定义第五层，第一类图形要素
            e4.AppendChild(e51);
            var e1version511 = xmlDoc.CreateElement("Name", "http://www.opengis.net/sld"); //定义图层名称
            e1version511.InnerText = "Single symbol";
            e51.AppendChild(e1version511);


            var e61 = xmlDoc.CreateElement("PolygonSymbolizer", "http://www.opengis.net/sld"); //定义第六层，面要素参数
            e51.AppendChild(e61);


            var e71 = xmlDoc.CreateElement("Fill", "http://www.opengis.net/sld"); //定义第七层，面要素填充参数
            e61.AppendChild(e71);


            var e81 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld"); //定义第七层，面要素填充参数
            XmlAttribute attrname1 = xmlDoc.CreateAttribute("name");
            attrname1.Value = "fill";
            e81.Attributes.Append(attrname1);
            e81.InnerText = polygonfillcolor;
            e71.AppendChild(e81);

            var e82 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
            XmlAttribute attrname2 = xmlDoc.CreateAttribute("name");
            attrname2.Value = "fill-opacity";
            e82.Attributes.Append(attrname2);
            e82.InnerText = polygonfillopacity;
            e71.AppendChild(e82);


            var e72 = xmlDoc.CreateElement("Stroke", "http://www.opengis.net/sld"); //定义第七层，面要素填充参数
            e61.AppendChild(e72);


            var e83 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld"); //定义第七层，面要素填充参数
            XmlAttribute attrname3 = xmlDoc.CreateAttribute("name");
            attrname3.Value = "stroke";
            e83.Attributes.Append(attrname3);
            e83.InnerText = polygonlinecolor;
            e72.AppendChild(e83);

            var e84 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
            XmlAttribute attrname4 = xmlDoc.CreateAttribute("name");
            attrname4.Value = "stroke-width";
            e84.Attributes.Append(attrname4);
            e84.InnerText = polygonlinewidth;
            e72.AppendChild(e84);

            var e85 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
            XmlAttribute attrname5 = xmlDoc.CreateAttribute("name");
            attrname5.Value = "stroke-linejoin";
            e85.Attributes.Append(attrname5);
            e85.InnerText = "bevel";
            e72.AppendChild(e85);

            if (polygonlinestyle != "")
            {
                var e86 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname6 = xmlDoc.CreateAttribute("name");
                attrname6.Value = "stroke-dasharray";
                e86.Attributes.Append(attrname6);
                e86.InnerText = polygonlinestyle;
                e72.AppendChild(e86);
            }

            var e87 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
            XmlAttribute attrname7 = xmlDoc.CreateAttribute("name");
            attrname7.Value = "stroke-opacity";
            e87.Attributes.Append(attrname7);
            e87.InnerText = polygonlineopacity;
            e72.AppendChild(e87);

            if (lablefieldname != "")
            {
                ///定义标注参数
                var e52 = xmlDoc.CreateElement("Rule", "http://www.opengis.net/sld"); //定义第五层，第一类标注要素
                e4.AppendChild(e52);
                var e62 = xmlDoc.CreateElement("TextSymbolizer", "http://www.opengis.net/sld");
                e52.AppendChild(e62);

                var e73 = xmlDoc.CreateElement("Label", "http://www.opengis.net/sld");
                e62.AppendChild(e73);

                var e88 = xmlDoc.CreateElement("ogc", "PropertyName", "http://www.opengis.net/ogc");
                e88.InnerText = lablefieldname;
                e73.AppendChild(e88);

                var e74 = xmlDoc.CreateElement("Font", "http://www.opengis.net/sld");
                e62.AppendChild(e74);

                var e89 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname8 = xmlDoc.CreateAttribute("name");
                attrname8.Value = "font-family";
                e89.Attributes.Append(attrname8);
                e89.InnerText = lablefont;
                e74.AppendChild(e89);

                var e810 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname9 = xmlDoc.CreateAttribute("name");
                attrname9.Value = "font-size";
                e810.Attributes.Append(attrname9);
                e810.InnerText = lablesize;
                e74.AppendChild(e810);

                var e811 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname10 = xmlDoc.CreateAttribute("name");
                attrname10.Value = "font-style";
                e811.Attributes.Append(attrname10);
                e811.InnerText = lablestyle;
                e74.AppendChild(e811);

                var e812 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname11 = xmlDoc.CreateAttribute("name");
                attrname11.Value = "font-weight";
                e812.Attributes.Append(attrname11);
                e812.InnerText = lablebold;
                e74.AppendChild(e812);


                var e75 = xmlDoc.CreateElement("LabelPlacement", "http://www.opengis.net/sld");
                e62.AppendChild(e75);

                var e813 = xmlDoc.CreateElement("PointPlacement", "http://www.opengis.net/sld");
                e75.AppendChild(e813);

                var e91 = xmlDoc.CreateElement("AnchorPoint", "http://www.opengis.net/sld");
                e813.AppendChild(e91);

                var e101 = xmlDoc.CreateElement("AnchorPointX", "http://www.opengis.net/sld");
                e101.InnerText = OffsetX;
                e91.AppendChild(e101);
                var e102 = xmlDoc.CreateElement("AnchorPointY", "http://www.opengis.net/sld");
                e102.InnerText = OffsetY;
                e91.AppendChild(e102);


                var e76 = xmlDoc.CreateElement("Fill", "http://www.opengis.net/sld");
                e62.AppendChild(e76);

                var e814 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname12 = xmlDoc.CreateAttribute("name");
                attrname12.Value = "fill";
                e814.Attributes.Append(attrname12);
                e814.InnerText = lablecolor;
                e76.AppendChild(e814);

                var e77 = xmlDoc.CreateElement("VendorOption", "http://www.opengis.net/sld");
                XmlAttribute attrname13 = xmlDoc.CreateAttribute("name");
                attrname13.Value = "maxDisplacement";
                e77.Attributes.Append(attrname13);
                e77.InnerText = maxdisplayment;
                e62.AppendChild(e77);

                var e78 = xmlDoc.CreateElement("VendorOption", "http://www.opengis.net/sld");
                XmlAttribute attrname14 = xmlDoc.CreateAttribute("name");
                attrname14.Value = "underlineText";
                e78.Attributes.Append(attrname14);
                e78.InnerText = lableunderline;
                e62.AppendChild(e78);

                var e79 = xmlDoc.CreateElement("VendorOption", "http://www.opengis.net/sld");
                XmlAttribute attrname15 = xmlDoc.CreateAttribute("name");
                attrname15.Value = "strikethroughText";
                e79.Attributes.Append(attrname15);
                e79.InnerText = lablestrikeout;
                e62.AppendChild(e79);
            }

            StreamWriter sw = new StreamWriter(sldxmlpath, false, new UTF8Encoding(false)); //编码改为无BOM  
            xmlDoc.Save(sw);
            sw.Close();

        }

        /// <summary>
        /// 线shp样式转化为SLD文件
        /// </summary>
        private void PolylineToSld(string sldxmlpath, ILayerSource layersinfo)
        {
            IFeatureSet Publishlayers = (IFeatureSet)layersinfo;
            /// 从图层属性中，读取写入sld文件需要用的参数
            string layername = Publishlayers.Name; //图层名称

            string oldfillcolor = Publishlayers.Style.Line.Color.Name.ToString();
            string polylinefillcolor = "#" + oldfillcolor.Substring(2, 6); //线条颜色

            string polylinefillopacity = Math.Round(Convert.ToDouble(Publishlayers.Style.Line.Transparency) / 255, 2).ToString();  //线条透明度

            string polylinewidth = Math.Round(Publishlayers.Style.Line.Width, 2).ToString();  //边界线宽

            string oldpolylinestyle = Publishlayers.Style.Line.DashStyle.ToString();  //边界线形, 需要加switch

            string polylinestyle = "";
            switch (oldpolylinestyle)
            {
                case "Solid":
                    polylinestyle = "";
                    break;
                case "Dash":
                    polylinestyle = "5 2";
                    break;
                case "Dot":
                    polylinestyle = "1 2";
                    break;
                case "DashDot":
                    polylinestyle = "4 2 1 2";
                    break;
                case "DashDotDot":
                    polylinestyle = "4 2 1 2 1 2";
                    break;
            }


            string oldlablecolor = Publishlayers.Labels.Style.FontColor.Name.ToString();
            string lablecolor = "#" + oldlablecolor.Substring(2, 6); //标注颜色

            string lablefont = "SimSun"; //Publishlayers.Labels.Style.FontName.ToString(); //标注字体

            string lablesize = Publishlayers.Labels.Style.FontSize.ToString(); //标注字体大小

            string oldlablestyle = Publishlayers.Labels.Style.FontItalic.ToString(); //标注字体是否斜体, true/false, 需要加switch
            string lablestyle = "normal";
            switch (oldlablestyle)
            {
                case "True":
                    lablestyle = "italic";
                    break;
                case "False":
                    lablestyle = "normal";
                    break;
            }
            string oldlablebold = Publishlayers.Labels.Style.FontBold.ToString(); //标注字体是否加粗, true/false, 需要加switch
            string lablebold = "normal";
            switch (oldlablebold)
            {
                case "True":
                    lablebold = "bold";
                    break;
                case "False":
                    lablebold = "normal";
                    break;
            }
            string lableunderline = Publishlayers.Labels.Style.FontUnderline.ToString(); //标注字体是否下划线, true/false
            string lablestrikeout = Publishlayers.Labels.Style.FontStrikeOut.ToString(); //标注字体是否删除线, true/false

            string lableopacity = Math.Round(Convert.ToDouble(Publishlayers.Labels.Style.FontTransparency) / 255, 2).ToString();  //标注透明度

            string lablefield = Publishlayers.Labels.Expression;  //标注的属性字段名称，需要将表达式处理为字段列表
            //string[] fieldlist = lablefield.Split("+");
            string lablefieldname = "";
            if (lablefield == "")
            {
                lablefieldname = "";
            }
            else
            {
                lablefieldname = lablefield.Substring(1, lablefield.Length - 2); //暂时只支持标注一个属性字段
            }

            /// 参数读取完毕
            /// 写入sld文件

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null)); //定义编码和版本


            XmlElement e1 = xmlDoc.CreateElement("StyledLayerDescriptor", "http://www.opengis.net/sld");

            XmlAttribute e1version1 = xmlDoc.CreateAttribute("version"); //定义命名空间
            e1version1.Value = "1.0.0";
            e1.Attributes.Append(e1version1);

            XmlAttribute e1version2 = xmlDoc.CreateAttribute("xsi", "schemaLocation", "http://www.w3.org/2001/XMLSchema-instance");
            e1version2.Value = "http://www.opengis.net/sld StyledLayerDescriptor.xsd";
            e1.Attributes.Append(e1version2);


            XmlAttribute e1version3 = xmlDoc.CreateAttribute("ogc", "xmlns", "http://www.opengis.net/ogc");
            e1.Attributes.Append(e1version3);
            XmlAttribute e1version4 = xmlDoc.CreateAttribute("xlink", "xmlns", "http://www.w3.org/1999/xlink");
            e1.Attributes.Append(e1version4);

            xmlDoc.AppendChild(e1);


            var e2 = xmlDoc.CreateElement("NamedLayer", "http://www.opengis.net/sld"); //定义第二层
            e1.AppendChild(e2);
            var e1version21 = xmlDoc.CreateElement("Name", "http://www.opengis.net/sld"); //定义图层名称
            e1version21.InnerText = layername;
            e2.AppendChild(e1version21);


            var e3 = xmlDoc.CreateElement("UserStyle", "http://www.opengis.net/sld"); //定义第三层
            e2.AppendChild(e3);
            var e1version31 = xmlDoc.CreateElement("Name", "http://www.opengis.net/sld"); //定义图层名称
            e1version31.InnerText = layername;
            e3.AppendChild(e1version31);


            var e4 = xmlDoc.CreateElement("FeatureTypeStyle", "http://www.opengis.net/sld"); //定义第四层
            e3.AppendChild(e4);


            var e51 = xmlDoc.CreateElement("Rule", "http://www.opengis.net/sld"); //定义第五层，第一类图形要素
            e4.AppendChild(e51);
            var e1version511 = xmlDoc.CreateElement("Name", "http://www.opengis.net/sld"); //定义图层名称
            e1version511.InnerText = "Single symbol";
            e51.AppendChild(e1version511);


            var e61 = xmlDoc.CreateElement("LineSymbolizer", "http://www.opengis.net/sld"); //定义第六层，面要素参数
            e51.AppendChild(e61);


            var e71 = xmlDoc.CreateElement("Stroke", "http://www.opengis.net/sld"); //定义第七层，面要素填充参数
            e61.AppendChild(e71);

            var e81 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld"); //定义第七层，面要素填充参数
            XmlAttribute attrname1 = xmlDoc.CreateAttribute("name");
            attrname1.Value = "stroke";
            e81.Attributes.Append(attrname1);
            e81.InnerText = polylinefillcolor;
            e71.AppendChild(e81);

            var e82 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
            XmlAttribute attrname2 = xmlDoc.CreateAttribute("name");
            attrname2.Value = "stroke-width";
            e82.Attributes.Append(attrname2);
            e82.InnerText = polylinewidth;
            e71.AppendChild(e82);

            var e83 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
            XmlAttribute attrname3 = xmlDoc.CreateAttribute("name");
            attrname3.Value = "stroke-linejoin";
            e83.Attributes.Append(attrname3);
            e83.InnerText = "bevel";
            e71.AppendChild(e83);

            var e84 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
            XmlAttribute attrname4 = xmlDoc.CreateAttribute("name");
            attrname4.Value = "stroke-dasharray";
            e84.Attributes.Append(attrname4);
            e84.InnerText = polylinestyle;
            e71.AppendChild(e84);

            var e85 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
            XmlAttribute attrname5 = xmlDoc.CreateAttribute("name");
            attrname5.Value = "stroke-linecap";
            e85.Attributes.Append(attrname5);
            e85.InnerText = "square";
            e71.AppendChild(e85);

            ///定义标注参数
            if (lablefieldname != "")
            {
                var e52 = xmlDoc.CreateElement("Rule", "http://www.opengis.net/sld"); //定义第五层，第一类标注要素
                e4.AppendChild(e52);
                var e62 = xmlDoc.CreateElement("TextSymbolizer", "http://www.opengis.net/sld");
                e52.AppendChild(e62);

                var e73 = xmlDoc.CreateElement("Label", "http://www.opengis.net/sld");
                e62.AppendChild(e73);

                var e88 = xmlDoc.CreateElement("ogc", "PropertyName", "http://www.opengis.net/ogc");
                e88.InnerText = lablefieldname;
                e73.AppendChild(e88);

                var e74 = xmlDoc.CreateElement("Font", "http://www.opengis.net/sld");
                e62.AppendChild(e74);

                var e89 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname8 = xmlDoc.CreateAttribute("name");
                attrname8.Value = "font-family";
                e89.Attributes.Append(attrname8);
                e89.InnerText = lablefont;
                e74.AppendChild(e89);

                var e810 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname9 = xmlDoc.CreateAttribute("name");
                attrname9.Value = "font-size";
                e810.Attributes.Append(attrname9);
                e810.InnerText = lablesize;
                e74.AppendChild(e810);

                var e811 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname10 = xmlDoc.CreateAttribute("name");
                attrname10.Value = "font-style";
                e811.Attributes.Append(attrname10);
                e811.InnerText = lablestyle;
                e74.AppendChild(e811);

                var e812 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname11 = xmlDoc.CreateAttribute("name");
                attrname11.Value = "font-weight";
                e812.Attributes.Append(attrname11);
                e812.InnerText = lablebold;
                e74.AppendChild(e812);


                var e75 = xmlDoc.CreateElement("LabelPlacement", "http://www.opengis.net/sld");
                e62.AppendChild(e75);

                var e813 = xmlDoc.CreateElement("LinePlacement", "http://www.opengis.net/sld");
                e75.AppendChild(e813);

                var e91 = xmlDoc.CreateElement("GeneralizeLine", "http://www.opengis.net/sld");
                e91.InnerText = "true";
                e813.AppendChild(e91);


                var e76 = xmlDoc.CreateElement("Fill", "http://www.opengis.net/sld");
                e62.AppendChild(e76);

                var e814 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname12 = xmlDoc.CreateAttribute("name");
                attrname12.Value = "fill";
                e814.Attributes.Append(attrname12);
                e814.InnerText = lablecolor;
                e76.AppendChild(e814);


                var e78 = xmlDoc.CreateElement("VendorOption", "http://www.opengis.net/sld");
                XmlAttribute attrname14 = xmlDoc.CreateAttribute("name");
                attrname14.Value = "underlineText";
                e78.Attributes.Append(attrname14);
                e78.InnerText = lableunderline;
                e62.AppendChild(e78);

                var e79 = xmlDoc.CreateElement("VendorOption", "http://www.opengis.net/sld");
                XmlAttribute attrname15 = xmlDoc.CreateAttribute("name");
                attrname15.Value = "strikethroughText";
                e79.Attributes.Append(attrname15);
                e79.InnerText = lablestrikeout;
                e62.AppendChild(e79);
            }

            StreamWriter sw = new StreamWriter(sldxmlpath, false, new UTF8Encoding(false)); //编码改为无BOM
            xmlDoc.Save(sw);
            sw.Close();

        }

        /// <summary>
        /// 点shp样式转化为SLD文件
        /// </summary>
        private void PointToSld(string sldxmlpath, ILayerSource layersinfo)
        {
            IFeatureSet Publishlayers = (IFeatureSet)layersinfo;
            // 从图层属性中，读取写入sld文件需要用的参数
            string layername = Publishlayers.Name; //图层名称

            string markeronline = "";
            string pointmarkersize = "";
            string vectormarker = "";
            string pointfillcolor = "";
            string pointfillopacity = "";
            string pointlinecolor = "";
            string pointlineopacity = "";
            string pointlinewidth = "";
            string pointsize = "";

            if (Publishlayers.Style.Marker.Icon != null)
            {
                string markername = Publishlayers.Style.Marker.Icon.Name; //样式图片名称
                markeronline = "http://www.linwutong.com/static/yunwudem/icon/" + markername + ".png";

                double IconScaleY = Publishlayers.Style.Marker.IconScaleY;
                pointmarkersize = (Publishlayers.Style.Marker.Icon.Height * IconScaleY).ToString(); //样式图片尺寸
            }
            else
            {
                vectormarker = Publishlayers.Style.Marker.VectorMarker.ToString(); //形状
                ArrayList markerArray = new ArrayList();
                markerArray.Add("Circle");
                markerArray.Add("Square");
                markerArray.Add("Triangle");
                markerArray.Add("Star");
                markerArray.Add("Cross");
                markerArray.Add("X");
                if (markerArray.Contains(vectormarker))
                {
                    vectormarker = vectormarker.ToLower();
                }
                else
                {
                    vectormarker = "square";
                }

                string oldfillcolor = Publishlayers.Style.Fill.Color.Name.ToString();
                pointfillcolor = "#" + oldfillcolor.Substring(2, 6); //面填充颜色

                pointfillopacity = Math.Round(Convert.ToDouble(Publishlayers.Style.Fill.Transparency) / 255, 2).ToString();  //填充颜色透明度

                string oldlinecolor = Publishlayers.Style.Line.Color.Name.ToString();
                pointlinecolor = "#" + oldlinecolor.Substring(2, 6);  //边界颜色

                pointlineopacity = Math.Round(Convert.ToDouble(Publishlayers.Style.Line.Transparency) / 255, 2).ToString();  //边界颜色透明度

                pointlinewidth = Math.Round(Publishlayers.Style.Line.Width, 2).ToString();  //边界线宽

                pointsize = Publishlayers.Style.Marker.Size.ToString();  //符号大小
            }



            /// 参数读取完毕
            /// 写入sld文件

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null)); //定义编码和版本


            XmlElement e1 = xmlDoc.CreateElement("StyledLayerDescriptor", "http://www.opengis.net/sld");

            XmlAttribute e1version1 = xmlDoc.CreateAttribute("version"); //定义命名空间
            e1version1.Value = "1.0.0";
            e1.Attributes.Append(e1version1);

            XmlAttribute e1version2 = xmlDoc.CreateAttribute("xsi", "schemaLocation", "http://www.w3.org/2001/XMLSchema-instance");
            e1version2.Value = "http://www.opengis.net/sld StyledLayerDescriptor.xsd";
            e1.Attributes.Append(e1version2);

            XmlAttribute e1version3 = xmlDoc.CreateAttribute("ogc", "xmlns", "http://www.opengis.net/ogc");
            e1.Attributes.Append(e1version3);
            XmlAttribute e1version4 = xmlDoc.CreateAttribute("xlink", "xmlns", "http://www.w3.org/1999/xlink");
            e1.Attributes.Append(e1version4);

            xmlDoc.AppendChild(e1);


            var e2 = xmlDoc.CreateElement("NamedLayer", "http://www.opengis.net/sld"); //定义第二层
            e1.AppendChild(e2);
            var e1version21 = xmlDoc.CreateElement("Name", "http://www.opengis.net/sld"); //定义图层名称
            e1version21.InnerText = layername;
            e2.AppendChild(e1version21);


            var e3 = xmlDoc.CreateElement("UserStyle", "http://www.opengis.net/sld"); //定义第三层
            e2.AppendChild(e3);
            var e1version31 = xmlDoc.CreateElement("Name", "http://www.opengis.net/sld"); //定义图层名称
            e1version31.InnerText = layername;
            e3.AppendChild(e1version31);
            var e1version32 = xmlDoc.CreateElement("Title", "http://www.opengis.net/sld"); //定义图层名称
            e1version32.InnerText = layername;
            e3.AppendChild(e1version32);
            var e1version33 = xmlDoc.CreateElement("Abstract", "http://www.opengis.net/sld"); //定义图层名称
            e3.AppendChild(e1version33);


            var e4 = xmlDoc.CreateElement("FeatureTypeStyle", "http://www.opengis.net/sld"); //定义第四层
            e3.AppendChild(e4);


            var e51 = xmlDoc.CreateElement("Rule", "http://www.opengis.net/sld"); //定义第五层，第一类图形要素
            e4.AppendChild(e51);
            var e1version511 = xmlDoc.CreateElement("Title", "http://www.opengis.net/sld"); //定义图层名称
            e1version511.InnerText = layername;
            e51.AppendChild(e1version511);


            var e61 = xmlDoc.CreateElement("PointSymbolizer", "http://www.opengis.net/sld"); //定义第六层，面要素参数
            e51.AppendChild(e61);


            var e71 = xmlDoc.CreateElement("Graphic", "http://www.opengis.net/sld"); //定义第七层，面要素填充参数
            e61.AppendChild(e71);

            if (Publishlayers.Style.Marker.Icon != null)
            {
                var e81 = xmlDoc.CreateElement("ExternalGraphic", "http://www.opengis.net/sld"); //定义第八层
                e71.AppendChild(e81);

                var e91 = xmlDoc.CreateElement("OnlineResource", "http://www.opengis.net/sld");

                XmlAttribute attrname1 = xmlDoc.CreateAttribute("xlink", "type", "http://www.w3.org/1999/xlink");
                attrname1.Value = "simple";
                e91.Attributes.Append(attrname1);
                XmlAttribute attrname2 = xmlDoc.CreateAttribute("xlink", "href", "http://www.w3.org/1999/xlink");
                attrname2.Value = markeronline;
                e91.Attributes.Append(attrname2);
                e81.AppendChild(e91);

                var e101 = xmlDoc.CreateElement("Format", "http://www.opengis.net/sld");
                e101.InnerText = "image/png";
                e81.AppendChild(e101);


                var e82 = xmlDoc.CreateElement("Size", "http://www.opengis.net/sld");
                e71.AppendChild(e82);

                var e92 = xmlDoc.CreateElement("ogc", "Literal", "http://www.opengis.net/ogc");
                e92.InnerText = pointmarkersize;
                e82.AppendChild(e92);
            }
            else
            {
                var e81 = xmlDoc.CreateElement("Mark", "http://www.opengis.net/sld"); //定义第八层
                e71.AppendChild(e81);

                var e91 = xmlDoc.CreateElement("WellKnownName", "http://www.opengis.net/sld");
                e91.InnerText = vectormarker;
                e81.AppendChild(e91);

                var e92 = xmlDoc.CreateElement("Fill", "http://www.opengis.net/sld"); //定义第七层，面要素填充参数
                e81.AppendChild(e92);


                var e101 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld"); //定义第七层，面要素填充参数
                XmlAttribute attrname1 = xmlDoc.CreateAttribute("name");
                attrname1.Value = "fill";
                e101.Attributes.Append(attrname1);
                e101.InnerText = pointfillcolor;
                e92.AppendChild(e101);

                var e102 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname2 = xmlDoc.CreateAttribute("name");
                attrname2.Value = "fill-opacity";
                e102.Attributes.Append(attrname2);
                e102.InnerText = pointfillopacity;
                e92.AppendChild(e102);


                var e93 = xmlDoc.CreateElement("Stroke", "http://www.opengis.net/sld"); //定义第七层，面要素填充参数
                e81.AppendChild(e93);

                var e103 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld"); //定义第七层，面要素填充参数
                XmlAttribute attrname3 = xmlDoc.CreateAttribute("name");
                attrname3.Value = "stroke";
                e103.Attributes.Append(attrname3);
                e103.InnerText = pointlinecolor;
                e93.AppendChild(e103);

                var e104 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname4 = xmlDoc.CreateAttribute("name");
                attrname4.Value = "stroke-width";
                e104.Attributes.Append(attrname4);
                e104.InnerText = pointlinewidth;
                e93.AppendChild(e104);

                var e105 = xmlDoc.CreateElement("CssParameter", "http://www.opengis.net/sld");
                XmlAttribute attrname5 = xmlDoc.CreateAttribute("name");
                attrname5.Value = "stroke-opacity";
                e105.Attributes.Append(attrname5);
                e105.InnerText = pointlineopacity;
                e93.AppendChild(e105);

                var e82 = xmlDoc.CreateElement("Size", "http://www.opengis.net/sld");
                e82.InnerText = pointsize;
                e71.AppendChild(e82);

            }

            StreamWriter sw = new StreamWriter(sldxmlpath, false, new UTF8Encoding(false)); //编码改为无BOM
            xmlDoc.Save(sw);
            sw.Close();

        }
    }
}
