namespace Oblikovati.Domain.Contracts;

public interface ILibrarySketchedSymbolDefinition
{

    ISketchedSymbolDefinitionLibrary Parent { get; }
    string Name { get; }
    ILibraryFolder ParentFolder { get; }
}
