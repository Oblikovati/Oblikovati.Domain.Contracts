using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchedSymbolDefinitionLibrary
{
    bool IsReadOnly { get; }
    ILibraryFolders Folders { get; }
    string Name { get; }
    ILibrarySketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
}