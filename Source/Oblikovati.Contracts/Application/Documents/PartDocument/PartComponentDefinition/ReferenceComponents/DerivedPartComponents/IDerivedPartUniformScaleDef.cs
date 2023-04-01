using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedPartComponents;

public interface IDerivedPartUniformScaleDef
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
    DerivedComponentOptionEnum IncludeAllSketches { get; set; }
    DerivedComponentOptionEnum IncludeAllWorkFeatures { get; set; }
    bool IncludeAlliMates { get; set; }
    bool Mirror { get; set; }
    DerivedPartMirrorPlaneEnum MirrorPlane { get; set; }
    double ScaleFactor { get; set; }
    IDerivedPartEntities Sketches { get; }
    IDerivedPartEntities Sketches3D { get; }
    IDerivedPartEntities WorkFeatures { get; }
    DerivedComponentOptionEnum IncludeAllSketches3D { get; set; }
    DerivedComponentOptionEnum IncludeAllSketchBlockDefinitions { get; set; }
    IDerivedPartEntities SketchBlockDefinitions { get; }
    IDerivedPartEntities SketchBlocks { get; }
    void IncludeAll();
    void ExcludeAll();
}