namespace Oblikovati.Domain.Contracts;

public interface IPlanarMoveDefinition
{

    IMoveFaceDefinition Parent { get; }
    object Plane { get; set; }
    object PointOne { get; set; }
    object PointTwo { get; set; }
}
