namespace Oblikovati.Domain.Contracts;

public interface IDirectionAndDistanceMoveDefinition
{

    IMoveFaceDefinition Parent { get; }
    object Direction { get; set; }
    bool DirectionReversed { get; set; }
    IParameter Distance { get; }
}
