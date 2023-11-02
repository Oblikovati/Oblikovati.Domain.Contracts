using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.NotClassified;

public interface IFixedWorkPointDef
{
    IWorkPoint Parent { get; }
    IPoint Point { get; set; }
}