namespace Oblikovati.Contracts.NotClassified;

public interface IFlatBendResults : IList<IFlatBendResults>
{
    IFlatBendResult Item { get; }
}