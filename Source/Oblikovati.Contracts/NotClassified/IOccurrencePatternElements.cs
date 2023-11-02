namespace Oblikovati.Contracts.NotClassified;

public interface IOccurrencePatternElements : IList<IOccurrencePatternElements>
{
    IOccurrencePattern Parent { get; }
    IOccurrencePatternElement Item { get; }
}