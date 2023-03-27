namespace Oblikovati.Domain.Contracts;

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
