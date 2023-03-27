namespace Oblikovati.Domain.Contracts;

public interface IDWGPolyline2DProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGEntitiesEnumerator Entities { get; }
    IDWGEntitySegmentsEnumerator Segments { get; }
    IDWGPolyline2D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
