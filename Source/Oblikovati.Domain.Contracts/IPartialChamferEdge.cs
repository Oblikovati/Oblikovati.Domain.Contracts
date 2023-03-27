namespace Oblikovati.Domain.Contracts;

public interface IPartialChamferEdge
{
    IChamferDefinition Parent { get; }
    IEdgeCollection Edge { get; }
    object StartDistance { get; set; }
    object ChamferDistance { get; set; }
    object EndDistance { get; set; }
    void Delete();
}
