using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Application.TransientBRep;

public interface IVertexDefinition
{
    int AssociativeID { get; set; }
    IPoint Position { get; set; }
}