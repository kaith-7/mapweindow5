using MW5.Api.Interfaces;

namespace MW5.Plugins.Services
{
    public interface IGeoprocessingService
    {
        /// <summary>
        /// Merges selected shapes
        /// </summary>
        void MergeShapes();

        /// <summary>
        /// Splits selected multipart shapes
        /// </summary>
        void ExplodeShapes();

        /// <summary>
        /// Removes selected shapes
        /// </summary>
        void RemoveSelectedShapes(bool prompt);
        void EditLineInvert();
        void EditLineJoin();
        void RemoveSelectedShapes(int layerHandle, bool prompt);

        bool BufferIsEmpty { get; }
        void CopyShapes();
        void SetAttributesCopy();
        bool HasAttributesCopy();
        void CopyAttributes();
        void PasteShapes();
        void CutShapes();

        void ReplaceShape(int layerHandle, int shapeIndex, IGeometry newGeometry);
    }
}
