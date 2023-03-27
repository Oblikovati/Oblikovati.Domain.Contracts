using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDerivedFutureAssemblyOccurrence
{
    IDerivedFutureAssemblyOccurrences SubOccurrences { get; }
    bool IsAssembly { get; }
    DerivedComponentOptionEnum InclusionOption { get; set; }

    string Name { get; }
}
