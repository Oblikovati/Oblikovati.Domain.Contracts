namespace Oblikovati.Domain.Contracts;

public interface IDWGPolyline3DProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGEntitiesEnumerator Entities { get; }
    IDWGEntitySegmentsEnumerator Segments { get; }
    IDWGPolyline3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
