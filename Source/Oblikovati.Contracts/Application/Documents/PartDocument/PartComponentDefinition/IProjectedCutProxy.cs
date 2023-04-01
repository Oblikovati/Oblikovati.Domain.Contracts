using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IProjectedCutProxy
{
    IAttributeSets AttributeSets { get; }
    string Name { get; set; }
    IPlanarSketch Parent { get; }
    ISketchEntitiesEnumerator SketchEntities { get; }
    IProjectedCut NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void BreakLink();
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}