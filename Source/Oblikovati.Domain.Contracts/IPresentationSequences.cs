namespace Oblikovati.Domain.Contracts;

public interface IPresentationSequences
{

    int Count { get; }
    IPresentationSequence Item { get; }
}
