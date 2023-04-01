using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.GraphicsDataSets;

namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface IPointGraphics : IGraphicsPrimitive
{
    IGraphicsCoordinateSet CoordinateSet { get; set; }
    IGraphicsIndexSet CoordinateIndexSet { get; set; }
    PointRenderStyleEnum PointRenderStyle { get; set; }
    int DepthPriority { get; set; }
    bool BurnThrough { get; set; }
    void GetCustomImage(out IGraphicsImageSet GraphicsImageSet, out int GraphicsImageIndex);
    void SetCustomImage(IGraphicsImageSet GraphicsImageSet, int GraphicsImageIndex);
}