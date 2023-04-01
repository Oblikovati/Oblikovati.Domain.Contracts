namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchedSymbolDefinitionLibraries : IList<ISketchedSymbolDefinitionLibraries>
{
    ISketchedSymbolDefinitionLibrary Item { get; }

    ISketchedSymbolDefinitionLibrary Add(string Name);
}