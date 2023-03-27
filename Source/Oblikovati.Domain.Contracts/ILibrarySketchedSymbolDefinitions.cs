namespace Oblikovati.Domain.Contracts;

public interface ILibrarySketchedSymbolDefinitions : IList<ILibrarySketchedSymbolDefinitions>
{

    int Count { get; }
    ILibrarySketchedSymbolDefinition Item { get; }
    IEnumerator GetEnumerator();
}
