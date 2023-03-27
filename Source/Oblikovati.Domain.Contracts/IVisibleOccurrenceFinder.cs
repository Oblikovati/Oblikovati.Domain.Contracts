namespace Oblikovati.Domain.Contracts;

public interface IVisibleOccurrenceFinder
{

    bool CompactResult { get; set; }
    IComponentOccurrencesEnumerator FoundOccurrences { get; }
    double PercentageVisible { get; set; }
    bool Visible { get; set; }
}
