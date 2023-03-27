namespace Oblikovati.Domain.Contracts;

public interface IOccurrencePatternElements : IList<IOccurrencePatternElements>
{

    IOccurrencePattern Parent { get; }
    int Count { get; }
    IOccurrencePatternElement Item { get; }
    IEnumerator GetEnumerator();
}
