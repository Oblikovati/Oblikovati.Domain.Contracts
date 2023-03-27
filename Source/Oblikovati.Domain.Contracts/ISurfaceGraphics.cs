using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISurfaceGraphics
{
    IGraphicsNode Parent { get; }

    IBox RangeBox { get; }
    bool Anchored { get; }
    int Id { get; }
    ISurfaceBody Body { get; }
    bool BurnThrough { get; set; }
    int DepthPriority { get; set; }
    IColor Color { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    double LineScale { get; set; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    ISurfaceGraphicsFaceList DisplayedFaces { get; }
    ISurfaceGraphicsEdgeList DisplayedEdges { get; }
    ISurfaceGraphicsVertexList DisplayedVertices { get; }
    bool DisplaySilhouettes { get; set; }
    bool ChildrenAreSelectable { get; set; }
    void Delete();
    void GetViewSpaceAnchor(out IPoint Origin, out IPoint2d Anchor, out ViewLayoutEnum AnchorRelativeTo);
    void SetViewSpaceAnchor(IPoint Origin, IPoint2d Anchor, ViewLayoutEnum AnchorRelativeTo);
    void RemoveViewSpaceAnchor();
    void SetTransformBehavior(IPoint Anchor, DisplayTransformBehaviorEnum BehaviorType, double PixelScale);
    void GetTransformBehavior(out IPoint TextAnchor, out DisplayTransformBehaviorEnum BehaviorType, out double PixelScale);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
