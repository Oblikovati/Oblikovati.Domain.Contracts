namespace Oblikovati.Domain.Contracts;

public interface IEdgeUseDefinition
{

    IEdgeDefinition EdgeDefinition { get; set; }
    bool IsOpposedToEdge { get; set; }
}
