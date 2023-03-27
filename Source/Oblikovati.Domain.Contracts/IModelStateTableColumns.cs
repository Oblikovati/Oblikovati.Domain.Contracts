namespace Oblikovati.Domain.Contracts;

public interface IModelStateTableColumns : IList<IModelStateTableColumns>
{

    int Count { get; }
    IModelStateTableColumn Item { get; }
    IEnumerator GetEnumerator();
}
