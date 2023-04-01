using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface ITextGraphics
{
    IGraphicsNode Parent { get; }

    IBox RangeBox { get; }
    bool Anchored { get; }
    int Id { get; }
    string Text { get; set; }
    int DepthPriority { get; set; }
    HorizontalTextAlignmentEnum HorizontalAlignment { get; set; }
    VerticalTextAlignmentEnum VerticalAlignment { get; set; }
    IPoint Anchor { get; set; }
    bool Bold { get; set; }
    bool Italic { get; set; }
    string Font { get; set; }
    double FontSize { get; set; }
    bool Scalable { get; }
    bool BurnThrough { get; set; }
    int _FontSize { get; set; }
    void Delete();
    void GetViewSpaceAnchor(out IPoint Origin, out IPoint2d Anchor, out ViewLayoutEnum AnchorRelativeTo);
    void SetViewSpaceAnchor(IPoint Origin, IPoint2d Anchor, ViewLayoutEnum AnchorRelativeTo);
    void RemoveViewSpaceAnchor();
    void GetTextColor(out byte Red, out byte Green, out byte Blue);
    void PutTextColor(byte Red, byte Green, byte Blue);
    void SetTransformBehavior(IPoint Anchor, DisplayTransformBehaviorEnum BehaviorType, double PixelScale);

    void GetTransformBehavior(out IPoint TextAnchor, out DisplayTransformBehaviorEnum BehaviorType,
        out double PixelScale);
}