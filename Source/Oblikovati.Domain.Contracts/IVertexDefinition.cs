namespace Oblikovati.Domain.Contracts;

public interface IVertexDefinition
{

    int AssociativeID { get; set; }
    IPoint Position { get; set; }
}
