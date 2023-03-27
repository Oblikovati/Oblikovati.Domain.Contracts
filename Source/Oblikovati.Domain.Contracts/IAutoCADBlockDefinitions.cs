namespace Oblikovati.Domain.Contracts;

public interface IAutoCADBlockDefinitions : IList<IAutoCADBlockDefinitions>
{

    IAutoCADBlockDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IAutoCADBlockDefinitionsEnumerator AddFromFile(string DWGFullFileName, object DefinitionNames, bool ReplaceExisting);
}
