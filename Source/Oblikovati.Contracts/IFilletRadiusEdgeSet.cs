using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface IFilletRadiusEdgeSet
{
    IEdgeCollection Edges { get; }
}