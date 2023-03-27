using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ITriangleGraphics
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
    bool HasCustomImage { get; set; }
    void Delete();
    void GetViewSpaceAnchor(out IPoint Origin, out IPoint2d Anchor, out ViewLayoutEnum AnchorRelativeTo);
    void SetViewSpaceAnchor(IPoint Origin, IPoint2d Anchor, ViewLayoutEnum AnchorRelativeTo);
    void RemoveViewSpaceAnchor();
    void SetTransformBehavior(IPoint Anchor, DisplayTransformBehaviorEnum BehaviorType, double PixelScale);
    void GetTransformBehavior(out IPoint TextAnchor, out DisplayTransformBehaviorEnum BehaviorType, out double PixelScale);
    void GetCustomImage(out IGraphicsImageSet ImageSet, out int ImageIndex);
    void SetCustomImage(IGraphicsImageSet ImageSet, int ImageIndex);
}
