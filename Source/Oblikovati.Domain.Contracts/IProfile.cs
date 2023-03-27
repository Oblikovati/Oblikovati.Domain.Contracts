namespace Oblikovati.Domain.Contracts;

public interface IProfile : IList<IProfile>
{

    int Count { get; }
    IProfilePath Item { get; }
    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool MergeFaces { get; set; }
    IRegionProperties RegionProperties { get; }
    IWires Wires { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    IEnumerator GetEnumerator();
}
