using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.NotClassified;

public interface ILibraryFolder
{
    ISketchedSymbolDefinitionLibrary Parent { get; }
    ILibraryFolder ParentFolder { get; }
    ILibraryFolders ChildFolders { get; }
    string Name { get; }
    ILibrarySketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
}