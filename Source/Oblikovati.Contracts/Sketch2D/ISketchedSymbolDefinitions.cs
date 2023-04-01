namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchedSymbolDefinitions : IList<ISketchedSymbolDefinitions>
{
    ISketchedSymbolDefinition Item { get; }

    ISketchedSymbolDefinitionLibraries SketchedSymbolDefinitionLibraries { get; }

    ISketchedSymbolDefinition Add(string Name);

    ISketchedSymbolDefinition AddFromLibrary(object SketchedSymbolDefinitionLibrary,
        string SketchedSymbolDefinitionName, object ReplaceExisting);

    void SaveAllToLibrary(object TargetSketchedSymbolDefinitionLibrary, object RetainResourceFolderStructure,
        object DestinationFolder, object ReplaceExisting);
}