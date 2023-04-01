namespace Oblikovati.Contracts;

public interface IFlatBendResults : IList<IFlatBendResults>
{
    IFlatBendResult Item { get; }
}