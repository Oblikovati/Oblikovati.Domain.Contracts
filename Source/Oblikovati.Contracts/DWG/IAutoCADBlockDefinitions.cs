namespace Oblikovati.Contracts.DWG;

public interface IAutoCADBlockDefinitions : IList<IAutoCADBlockDefinitions>
{
    IAutoCADBlockDefinition Item { get; }


    IAutoCADBlockDefinitionsEnumerator
        AddFromFile(string DWGFullFileName, object DefinitionNames, bool ReplaceExisting);
}