namespace Oblikovati.Contracts.NotClassified;

public interface IDirectEditOperations : IList<IDirectEditOperations>
{
    IDirectEditOperation Item { get; }
}