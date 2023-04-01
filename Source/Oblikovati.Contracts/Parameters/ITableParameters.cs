namespace Oblikovati.Contracts.Parameters;

public interface ITableParameters : IList<ITableParameters>
{
    ITableParameter Item { get; }
}