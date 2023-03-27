using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
