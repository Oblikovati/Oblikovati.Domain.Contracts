using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch2D.Profiles;

public interface IProfileProxy : IList<IProfileProxy>
{
    IProfilePath Item { get; }
    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool MergeFaces { get; set; }
    IRegionProperties RegionProperties { get; }
    IWires Wires { get; }
    IProfile NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }

    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}