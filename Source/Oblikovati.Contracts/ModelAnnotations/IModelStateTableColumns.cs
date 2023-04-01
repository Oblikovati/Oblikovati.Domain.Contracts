namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelStateTableColumns : IList<IModelStateTableColumns>
{
    IModelStateTableColumn Item { get; }
}