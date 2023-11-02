using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.DWG;

public interface IDWGLine
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IUnitVector Direction { get; }
    IPoint EndPoint { get; }
    IPoint StartPoint { get; }
}