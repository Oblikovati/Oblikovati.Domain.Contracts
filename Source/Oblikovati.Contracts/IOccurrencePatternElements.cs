namespace Oblikovati.Contracts;

public interface IOccurrencePatternElements : IList<IOccurrencePatternElements>
{
    IOccurrencePattern Parent { get; }
    IOccurrencePatternElement Item { get; }
}