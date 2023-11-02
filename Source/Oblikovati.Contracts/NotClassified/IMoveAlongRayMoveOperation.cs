namespace Oblikovati.Contracts.NotClassified;

public interface IMoveAlongRayMoveOperation
{
    IMoveDefinition Parent { get; }
    object DirectionEntity { get; set; }
    bool EntityNaturalDirection { get; set; }
    object Offset { get; set; }
    void Delete();
}