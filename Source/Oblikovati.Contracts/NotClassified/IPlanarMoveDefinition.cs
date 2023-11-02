namespace Oblikovati.Contracts.NotClassified;

public interface IPlanarMoveDefinition
{
    IMoveFaceDefinition Parent { get; }
    object Plane { get; set; }
    object PointOne { get; set; }
    object PointTwo { get; set; }
}