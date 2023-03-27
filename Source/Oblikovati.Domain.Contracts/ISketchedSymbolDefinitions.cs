namespace Oblikovati.Domain.Contracts;

public interface ISketchedSymbolDefinitions : IList<ISketchedSymbolDefinitions>
{

    ISketchedSymbolDefinition Item { get; }
    int Count { get; }
    ISketchedSymbolDefinitionLibraries SketchedSymbolDefinitionLibraries { get; }
    IEnumerator GetEnumerator();
    ISketchedSymbolDefinition Add(string Name);
    ISketchedSymbolDefinition AddFromLibrary(object SketchedSymbolDefinitionLibrary, string SketchedSymbolDefinitionName, object ReplaceExisting);
    void SaveAllToLibrary(object TargetSketchedSymbolDefinitionLibrary, object RetainResourceFolderStructure, object DestinationFolder, object ReplaceExisting);
}
