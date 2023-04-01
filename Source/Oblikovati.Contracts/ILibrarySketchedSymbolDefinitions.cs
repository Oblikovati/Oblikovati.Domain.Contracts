namespace Oblikovati.Contracts;

public interface ILibrarySketchedSymbolDefinitions : IList<ILibrarySketchedSymbolDefinitions>
{
    ILibrarySketchedSymbolDefinition Item { get; }
}