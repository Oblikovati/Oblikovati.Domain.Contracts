namespace Oblikovati.Domain.Contracts;

public interface IDWGEntitySegmentProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGEntitySegment NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
