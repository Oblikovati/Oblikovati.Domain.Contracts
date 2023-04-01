using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts;

public interface ILibraryFolder
{
    ISketchedSymbolDefinitionLibrary Parent { get; }
    ILibraryFolder ParentFolder { get; }
    ILibraryFolders ChildFolders { get; }
    string Name { get; }
    ILibrarySketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
}