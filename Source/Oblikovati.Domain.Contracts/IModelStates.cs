using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelStates : IList<IModelStates>
{

    IComponentDefinition Parent { get; }
    int Count { get; }
    IModelState Item { get; }
    object ExcelWorkSheet { get; }
    MemberEditScopeEnum MemberEditScope { get; set; }
    IModelStateTable ModelStateTable { get; }
    IModelState ActiveModelState { get; }
    IEnumerator GetEnumerator();
    IModelState Add(string Name);
    IModelState AddSubstitute(string FullFileName, object Name, object SkipDocumentSave);
}
