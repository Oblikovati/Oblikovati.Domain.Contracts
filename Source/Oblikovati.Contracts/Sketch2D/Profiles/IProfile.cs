using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch2D.Profiles;

public interface IProfile : IList<IProfile>
{
    IProfilePath Item { get; }
    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool MergeFaces { get; set; }
    IRegionProperties RegionProperties { get; }
    IWires Wires { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}