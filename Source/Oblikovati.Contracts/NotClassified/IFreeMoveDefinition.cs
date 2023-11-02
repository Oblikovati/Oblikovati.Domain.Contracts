namespace Oblikovati.Contracts.NotClassified;

public interface IFreeMoveDefinition
{
    IMoveFaceDefinition Parent { get; }
    IMatrix Transformation { get; set; }
}