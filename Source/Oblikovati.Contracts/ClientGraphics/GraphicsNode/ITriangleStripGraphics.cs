using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.GraphicsDataSets;

namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface ITriangleStripGraphics
{
    IGraphicsNode Parent { get; }

    IBox RangeBox { get; }
    bool Anchored { get; }
    int Id { get; }
    IGraphicsCoordinateSet CoordinateSet { get; set; }
    IGraphicsIndexSet CoordinateIndexSet { get; set; }
    IGraphicsNormalSet NormalSet { get; set; }
    IGraphicsIndexSet NormalIndexSet { get; set; }
    NormalBindingEnum NormalBinding { get; set; }
    IGraphicsColorSet ColorSet { get; set; }
    IGraphicsIndexSet ColorIndexSet { get; set; }
    ColorBindingEnum ColorBinding { get; set; }
    int DepthPriority { get; set; }
    bool BurnThrough { get; set; }
    IGraphicsColorMapper ColorMapper { get; set; }
    IGraphicsIndexSet TextureCoordinateIndexSet { get; set; }
    IGraphicsTextureCoordinateSet TextureCoordinateSet { get; set; }
    BackFaceCullingEnum BackFaceCulling { get; set; }
    void Delete();
    void GetViewSpaceAnchor(out IPoint Origin, out IPoint2d Anchor, out ViewLayoutEnum AnchorRelativeTo);
    void SetViewSpaceAnchor(IPoint Origin, IPoint2d Anchor, ViewLayoutEnum AnchorRelativeTo);
    void RemoveViewSpaceAnchor();
    void GetStripLengths(ref List<int> StripLengths);
    void PutStripLengths(ref List<int> StripLengths);
    void SetTransformBehavior(IPoint Anchor, DisplayTransformBehaviorEnum BehaviorType, double PixelScale);

    void GetTransformBehavior(out IPoint TextAnchor, out DisplayTransformBehaviorEnum BehaviorType,
        out double PixelScale);
}