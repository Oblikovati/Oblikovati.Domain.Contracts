namespace Oblikovati.Contracts.Application.TransientBRep;

public interface IEdgeLoopDefinitions : IList<IEdgeLoopDefinitions>
{
    IEdgeLoopDefinition Item { get; }


    IEdgeLoopDefinition Add();
}