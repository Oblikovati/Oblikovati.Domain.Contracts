using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientBRep;

public interface IEdgeUseDefinition
{
    IEdgeDefinition EdgeDefinition { get; set; }
    bool IsOpposedToEdge { get; set; }
}