using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts;

public interface IDirectionAndDistanceMoveDefinition
{
    IMoveFaceDefinition Parent { get; }
    object Direction { get; set; }
    bool DirectionReversed { get; set; }
    IParameter Distance { get; }
}