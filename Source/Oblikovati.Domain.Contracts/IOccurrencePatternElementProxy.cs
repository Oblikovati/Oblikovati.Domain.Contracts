namespace Oblikovati.Domain.Contracts;

public interface IOccurrencePatternElementProxy
{


    string Name { get; }
    bool Independent { get; set; }
    bool Suppressed { get; set; }
    IComponentOccurrencesEnumerator Occurrences { get; }
    IObjectsEnumerator Components { get; }
    int Index { get; }
    IOccurrencePatternElement NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
