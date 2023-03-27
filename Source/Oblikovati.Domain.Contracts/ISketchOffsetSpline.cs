using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchOffsetSpline
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    object ReferencedEntity { get; }
    IBox2d RangeBox { get; }
    ISketchConstraintsEnumerator Constraints { get; }
    bool Reference { get; set; }
    bool Construction { get; set; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    ILayer Layer { get; set; }
    GeometryMoveableStatusEnum _GeometryMoveableStatus { get; }
    ISketchEntitiesEnumerator OwnedBy { get; }
    bool SketchOnly { get; set; }
    ISketchBlock ContainingSketchBlock { get; }
    ISketchBlocksEnumerator SketchBlockPath { get; }
    IBSplineCurve2d Geometry { get; }
    double Length { get; }
    bool Closed { get; }
    ISketchPoint EndSketchPoint { get; }
    ISketchPoint StartSketchPoint { get; }
    IColor OverrideColor { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    double LineScale { get; set; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    ISketchSpline OriginalSpline { get; }
    bool CurvatureDisplay { get; set; }
    IBSplineCurve Geometry3d { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    ISketchSpline ConvertToSpline();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
