namespace Oblikovati.Domain.Contracts;

public interface IFreeMoveDefinition
{

    IMoveFaceDefinition Parent { get; }
    IMatrix Transformation { get; set; }
}
