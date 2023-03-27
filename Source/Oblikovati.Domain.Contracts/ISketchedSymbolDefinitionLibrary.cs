namespace Oblikovati.Domain.Contracts;

public interface ISketchedSymbolDefinitionLibrary
{

    bool IsReadOnly { get; }
    ILibraryFolders Folders { get; }
    string Name { get; }
    ILibrarySketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
}
