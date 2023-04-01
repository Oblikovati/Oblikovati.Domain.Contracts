using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchedSymbols : IList<ISketchedSymbols>
{
    ISketchedSymbol Item { get; }


    ISketchedSymbol _Add(object SketchedSymbolDefinition, IPoint2d Position, object PromptStrings);

    ISketchedSymbol Add(object SketchedSymbolDefinition, IPoint2d Position, double Rotation, double Scale,
        object PromptStrings);

    ISketchedSymbol AddWithLeader(object SketchedSymbolDefinition, IObjectCollection LeaderPoints, double Rotation,
        double Scale, object PromptStrings, bool SymbolClipping, bool Static);
}