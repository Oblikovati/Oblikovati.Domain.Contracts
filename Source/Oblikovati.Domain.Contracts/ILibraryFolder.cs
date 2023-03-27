namespace Oblikovati.Domain.Contracts;

public interface ILibraryFolder
{

    ISketchedSymbolDefinitionLibrary Parent { get; }
    ILibraryFolder ParentFolder { get; }
    ILibraryFolders ChildFolders { get; }
    string Name { get; }
    ILibrarySketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
}
