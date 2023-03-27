using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDerivedAssemblyOccurrence
{
    IComponentOccurrence ReferencedOccurrence { get; }
    IDerivedAssemblyOccurrences SubOccurrences { get; }
    bool IsAssembly { get; }
    DerivedComponentOptionEnum InclusionOption { get; set; }

    string Name { get; }
    bool FailedBooleanOperation { get; }
}
