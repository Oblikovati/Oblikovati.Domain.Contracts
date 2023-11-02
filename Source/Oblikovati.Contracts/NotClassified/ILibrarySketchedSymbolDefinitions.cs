namespace Oblikovati.Contracts.NotClassified;

public interface ILibrarySketchedSymbolDefinitions : IList<ILibrarySketchedSymbolDefinitions>
{
    ILibrarySketchedSymbolDefinition Item { get; }
}