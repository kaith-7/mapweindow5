using System.ComponentModel;
using System.IO;
using MW5.Api.Enums;

namespace MW5.Services.Controls
{
    public class MissingLayer
    {
        public MissingLayer(string name, string filename, LayerType layerType, object tag)
        {
            Name = name;
            Filename = filename;
            Tag = tag;
            LayerType = layerType;
        }
        
        [Browsable(false)]
        public object Tag { get; private set; }

        [Browsable(false)]
        public LayerType LayerType { get; private set; }

        [DisplayName("图层名称")]
        public string Name { get; private set; }

        [DisplayName("数据源")]
        public string Filename { get; set; }

        [DisplayName("Found")]
        public bool Found
        {
            get { return File.Exists(Filename); }
        }
    }
}
