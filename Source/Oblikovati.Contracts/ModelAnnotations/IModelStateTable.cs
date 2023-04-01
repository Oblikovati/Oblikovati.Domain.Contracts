using Oblikovati.Contracts.Application.Documents;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelStateTable
{
    IAttributeSets AttributeSets { get; }
    IModelStates Parent { get; }
    IModelStateTableRows TableRows { get; }
    IModelStateTableColumns TableColumns { get; }
}