namespace Oblikovati.Contracts;

public interface IDirectEditOperations : IList<IDirectEditOperations>
{
    IDirectEditOperation Item { get; }
}