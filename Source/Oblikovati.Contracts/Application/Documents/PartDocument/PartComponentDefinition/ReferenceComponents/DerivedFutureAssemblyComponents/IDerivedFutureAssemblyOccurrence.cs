using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedFutureAssemblyComponents;

public interface IDerivedFutureAssemblyOccurrence
{
    IDerivedFutureAssemblyOccurrences SubOccurrences { get; }
    bool IsAssembly { get; }
    DerivedComponentOptionEnum InclusionOption { get; set; }

    string Name { get; }
}