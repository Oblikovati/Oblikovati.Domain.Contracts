namespace Oblikovati.Domain.Contracts;

public interface IModelStateTableRows : IList<IModelStateTableRows>
{

    int Count { get; }
    IModelStateTableRow Item { get; }
    IEnumerator GetEnumerator();
}
