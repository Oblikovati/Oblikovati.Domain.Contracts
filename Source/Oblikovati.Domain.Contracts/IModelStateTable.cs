namespace Oblikovati.Domain.Contracts;

public interface IModelStateTable
{

    IAttributeSets AttributeSets { get; }
    IModelStates Parent { get; }
    IModelStateTableRows TableRows { get; }
    IModelStateTableColumns TableColumns { get; }
}
