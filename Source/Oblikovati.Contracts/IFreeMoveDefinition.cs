using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts;

public interface IFreeMoveDefinition
{
    IMoveFaceDefinition Parent { get; }
    IMatrix Transformation { get; set; }
}