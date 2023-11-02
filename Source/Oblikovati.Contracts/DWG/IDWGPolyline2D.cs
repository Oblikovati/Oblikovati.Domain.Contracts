using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.DWG;

public interface IDWGPolyline2D
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGEntitiesEnumerator Entities { get; }
    IDWGEntitySegmentsEnumerator Segments { get; }
}