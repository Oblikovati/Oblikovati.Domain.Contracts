namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelStateTableRows : IList<IModelStateTableRows>
{
    IModelStateTableRow Item { get; }
}