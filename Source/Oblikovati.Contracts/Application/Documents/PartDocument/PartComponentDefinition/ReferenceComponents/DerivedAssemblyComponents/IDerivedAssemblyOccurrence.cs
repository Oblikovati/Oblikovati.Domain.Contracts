using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedAssemblyComponents;

public interface IDerivedAssemblyOccurrence
{
    IComponentOccurrence ReferencedOccurrence { get; }
    IDerivedAssemblyOccurrences SubOccurrences { get; }
    bool IsAssembly { get; }
    DerivedComponentOptionEnum InclusionOption { get; set; }

    string Name { get; }
    bool FailedBooleanOperation { get; }
}