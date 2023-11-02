using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientBRep;

public interface IEdgeUseDefinitions : IList<IEdgeUseDefinitions>
{
    IEdgeUseDefinition Item { get; }


    IEdgeUseDefinition Add(IEdgeDefinition EdgeDefinition, bool IsOpposedToEdge);
}