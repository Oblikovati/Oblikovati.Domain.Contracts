using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.NotClassified;

public interface ILibrarySketchedSymbolDefinition
{
    ISketchedSymbolDefinitionLibrary Parent { get; }
    string Name { get; }
    ILibraryFolder ParentFolder { get; }
}