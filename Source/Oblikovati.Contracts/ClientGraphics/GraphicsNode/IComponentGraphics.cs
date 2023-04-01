using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface IComponentGraphics
{
    IGraphicsNode Parent { get; }

    IBox RangeBox { get; }
    bool Anchored { get; }
    int Id { get; }
    ISurfaceBody Body { get; }
    bool BurnThrough { get; set; }
    IColor Color { get; set; }
    int DepthPriority { get; set; }
    bool DisplaySilhouettes { get; set; }
    ISurfaceGraphicsEdgeList DisplayedEdges { get; }
    ISurfaceGraphicsFaceList DisplayedFaces { get; }
    LineTypeEnum LineType { get; set; }
    double LineScale { get; set; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    double LineWeight { get; set; }
    void Delete();
    void GetViewSpaceAnchor(out IPoint Origin, out IPoint2d Anchor, out ViewLayoutEnum AnchorRelativeTo);
    void SetViewSpaceAnchor(IPoint Origin, IPoint2d Anchor, ViewLayoutEnum AnchorRelativeTo);
    void RemoveViewSpaceAnchor();

    void GetTransformBehavior(out IPoint TextAnchor, out DisplayTransformBehaviorEnum BehaviorType,
        out double PixelScale);

    void SetTransformBehavior(IPoint Anchor, DisplayTransformBehaviorEnum BehaviorType, double PixelScale);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}