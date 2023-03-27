namespace Oblikovati.Domain.Contracts;

public interface IProfileProxy : IList<IProfileProxy>
{

    int Count { get; }
    IProfilePath Item { get; }
    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool MergeFaces { get; set; }
    IRegionProperties RegionProperties { get; }
    IWires Wires { get; }
    IProfile NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    IEnumerator GetEnumerator();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}
