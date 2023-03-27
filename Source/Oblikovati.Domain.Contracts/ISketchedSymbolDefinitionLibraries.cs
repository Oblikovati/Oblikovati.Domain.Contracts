namespace Oblikovati.Domain.Contracts;

public interface ISketchedSymbolDefinitionLibraries : IList<ISketchedSymbolDefinitionLibraries>
{

    int Count { get; }
    ISketchedSymbolDefinitionLibrary Item { get; }
    IEnumerator GetEnumerator();
    ISketchedSymbolDefinitionLibrary Add(string Name);
}
