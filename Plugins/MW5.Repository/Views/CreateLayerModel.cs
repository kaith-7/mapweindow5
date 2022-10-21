using MW5.Api.Enums;
using System.IO;

namespace MW5.Plugins.Repository.Views
{
    public class CreateLayerModel
    {
        public CreateLayerModel()
        {
            Filename = string.Empty;
            GeometryType = GeometryType.None;
            ZValueType = ZValueType.None;
            MemoryLayer = false;
        }

        public GeometryType GeometryType { get; set; }

        public string Filename { get; set; }

        public ZValueType ZValueType { get; set; }

        public bool MemoryLayer { get; set; }

        public string LayerName
        {
            get { return MemoryLayer ? Filename : Path.GetFileNameWithoutExtension(Filename); }
        }
    }
}
