using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Application.TransientBRep;

public interface IVertexDefinitions : IList<IVertexDefinitions>
{
    IVertexDefinition Item { get; }


    IVertexDefinition Add(IPoint Position);
}