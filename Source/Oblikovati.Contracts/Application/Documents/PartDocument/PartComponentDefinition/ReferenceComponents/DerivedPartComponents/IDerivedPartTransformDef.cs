using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedPartComponents;

public interface IDerivedPartTransformDef
{
    DerivedComponentOptionEnum IncludeAllSurfaces { get; set; }
    bool IncludeAllParameters { get; set; }
    bool IncludeBody { get; set; }
    bool BodyAsSolidBody { get; set; }
    IDerivedPartEntities Surfaces { get; }
    IDerivedPartEntities iMateDefinitions { get; }
    IDerivedPartEntities Parameters { get; }
    DerivedComponentStyleEnum DeriveStyle { get; set; }
    DerivedComponentOptionEnum IncludeAllSolids { get; set; }
    IDerivedPartEntities Solids { get; }
    DerivedComponentOptionEnum IncludeAlliMateDefinitions { get; set; }
    string ActiveDesignViewRepresentation { get; set; }
    bool IsAssociativeDesignView { get; set; }
    bool ReducedMemoryMode { get; set; }
    bool UseColorOverridesFromSource { get; set; }
    string ActiveModelState { get; set; }
    void IncludeAll();
    void ExcludeAll();
    void SetTransformation(IMatrix Transform, bool Mirror);
    void GetTransformation(out IMatrix Transform, out bool Mirror);
}