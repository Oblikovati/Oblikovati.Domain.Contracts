using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.DWG;

public interface IDWGPoint
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IPoint Point { get; }
}