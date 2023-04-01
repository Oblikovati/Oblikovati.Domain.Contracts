using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;

namespace Oblikovati.Contracts;

public interface IVisibleOccurrenceFinder
{
    bool CompactResult { get; set; }
    IComponentOccurrencesEnumerator FoundOccurrences { get; }
    double PercentageVisible { get; set; }
    bool Visible { get; set; }
}