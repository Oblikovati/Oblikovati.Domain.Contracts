using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.NotClassified;

public interface IDirectionAndDistanceMoveDefinition
{
    IMoveFaceDefinition Parent { get; }
    object Direction { get; set; }
    bool DirectionReversed { get; set; }
    IParameter Distance { get; }
}