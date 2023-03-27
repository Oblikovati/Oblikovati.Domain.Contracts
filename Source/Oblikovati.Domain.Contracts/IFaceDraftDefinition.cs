using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFaceDraftDefinition
{
    bool AbsoluteDraftAngle { get; set; }

    bool AutomaticBlending { get; set; }
    bool CutMaterial { get; set; }
    FaceDraftDefinitionTypeEnum DefinitionType { get; }
    object DraftAngle { get; set; }
    DraftAngleConstraintTypeEnum DraftAngleConstraintType { get; set; }
    object DraftAngleTwo { get; set; }
    IEdgeCollection FixedEdges { get; set; }
    IFaceCollection InputFaces { get; set; }
    IFaceDraftFeature Parent { get; }
    object PullDirection { get; }
    bool PullDirectionReversed { get; set; }
    IFaceDraftDefinition Copy();
    void SetFixedEdge(IFaceCollection InputFaces, IEdgeCollection FixedEdges, object PullDirection, object DraftAngle, bool PullDirectionReversed, bool AbsoluteDraftAngle);
    void SetFixedPlane(IFaceCollection InputFaces, object FixedPlane, object DraftAngle, DraftAngleConstraintTypeEnum DraftAngleConstraintType, object DraftAngleTwo, bool AbsoluteDraftAngle);
    void SetPartingTool(IFaceCollection InputFaces, object PartingTool, object PullDirection, object DraftAngle, bool CutMaterial, object FixedEdges, DraftAngleConstraintTypeEnum DraftAngleConstraintType, object DraftAngleTwo, bool PullDirectionReversed, bool AbsoluteDraftAngle);
}
