namespace Oblikovati.Domain.Contracts;

public interface ITableParameters : IList<ITableParameters>
{
    ITableParameter Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
