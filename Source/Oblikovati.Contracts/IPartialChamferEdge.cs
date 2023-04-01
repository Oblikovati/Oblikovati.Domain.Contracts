using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface IPartialChamferEdge
{
    IChamferDefinition Parent { get; }
    IEdgeCollection Edge { get; }
    object StartDistance { get; set; }
    object ChamferDistance { get; set; }
    object EndDistance { get; set; }
    void Delete();
}