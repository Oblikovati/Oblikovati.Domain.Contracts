using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedPartComponents;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedFuturePartComponents;

public interface IDerivedFuturePartDefinition
{
    string ActiveDesignViewRepresentation { get; set; }
    string FullFileName { get; }
    DerivedComponentOptionEnum IncludeAllSolids { get; set; }
    DerivedComponentOptionEnum IncludeAllSurfaces { get; set; }
    bool IsAssociativeDesignView { get; set; }
    IDerivedPartEntities Solids { get; }
    IDerivedPartEntities Surfaces { get; }
    void ExcludeAll();
    void IncludeAll();
}