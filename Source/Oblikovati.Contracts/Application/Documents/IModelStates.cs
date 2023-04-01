using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.ModelAnnotations;

namespace Oblikovati.Contracts.Application.Documents;

public interface IModelStates : IList<IModelStates>
{
    IComponentDefinition Parent { get; }

    IModelState Item { get; }
    object ExcelWorkSheet { get; }
    MemberEditScopeEnum MemberEditScope { get; set; }
    IModelStateTable ModelStateTable { get; }
    IModelState ActiveModelState { get; }

    IModelState Add(string Name);
    IModelState AddSubstitute(string FullFileName, object Name, object SkipDocumentSave);
}