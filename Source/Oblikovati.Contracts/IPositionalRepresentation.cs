using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.AssemblyConstraints;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPositionalRepresentation
{
    IRepresentationsManager Parent { get; }
    string Name { get; set; }
    IAttributeSets AttributeSets { get; }
    bool Master { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Activate();
    IPositionalRepresentation Copy(string NewName);
    void Delete();
    bool IsConstraintValueOverridden(IAssemblyConstraint Constraint, out string Expression);
    void SetConstraintValueOverride(IAssemblyConstraint Constraint, string Expression);
    void RemoveConstraintValueOverride(IAssemblyConstraint Constraint);
    bool IsConstraintSuppressionOverridden(IAssemblyConstraint Constraint, out bool Suppressed);
    void SetConstraintSuppressionOverride(IAssemblyConstraint Constraint, bool Suppressed);
    void RemoveConstraintSuppressionOverride(IAssemblyConstraint Constraint);
    bool IsTransformOverridden(IComponentOccurrence Occurrence, out IMatrix Transform);
    void SetTransformOverride(IComponentOccurrence Occurrence, IMatrix Transform);
    void RemoveTransformOverride(IComponentOccurrence Occurrence);
    bool IsGroundingOverridden(IComponentOccurrence Occurrence, out bool Grounded);
    void SetGroundingOverride(IComponentOccurrence Occurrence, bool Grounded);
    void RemoveGroundingOverride(IComponentOccurrence Occurrence);
    bool IsFlexibleOverridden(IComponentOccurrence Occurrence, out bool Flexible);
    void SetFlexibleOverride(IComponentOccurrence Occurrence, bool Flexible);
    void RemoveFlexibleOverride(IComponentOccurrence Occurrence);
    bool IsPositionalRepresentationOverridden(IComponentOccurrence Occurrence, out string Representation);
    void SetPositionalRepresentationOverride(IComponentOccurrence Occurrence, string Representation);
    void RemovePositionalRepresentationOverride(IComponentOccurrence Occurrence);
    bool IsPatternColumnOffsetOverridden(IRectangularOccurrencePattern Pattern, out string ColumnOffset);
    void SetPatternColumnOffsetOverride(IRectangularOccurrencePattern Pattern, string ColumnOffset);
    void RemovePatternColumnOffsetOverride(IRectangularOccurrencePattern Pattern);
    bool IsPatternRowOffsetOverridden(IRectangularOccurrencePattern Pattern, out string RowOffset);
    void SetPatternRowOffsetOverride(IRectangularOccurrencePattern Pattern, string RowOffset);
    void RemovePatternRowOffsetOverride(IRectangularOccurrencePattern Pattern);
    bool IsPatternAngleOffsetOverridden(ICircularOccurrencePattern Pattern, out string AngleOffset);
    void SetPatternAngleOffsetOverride(ICircularOccurrencePattern Pattern, string AngleOffset);
    void RemovePatternAngleOffsetOverride(ICircularOccurrencePattern Pattern);
    void ClearRelationshipOverrides(object Relationship);
    bool IsRelationshipSuppressionOverridden(object Relationship, out bool Suppressed);
    void SetRelationshipSuppressionOverride(object Relationship, bool Suppressed);
    void RemoveRelationshipSuppressionOverride(object Relationship);

    bool IsRelationshipValueOverridden(object Relationship, RelationshipValueTypeEnum RelationShipValueType,
        out string Expression);

    void SetRelationshipValueOverride(object Relationship, RelationshipValueTypeEnum RelationShipValueType,
        string Expression);

    void RemoveRelationshipValueOverride(object Relationship, RelationshipValueTypeEnum RelationShipValueType);
}