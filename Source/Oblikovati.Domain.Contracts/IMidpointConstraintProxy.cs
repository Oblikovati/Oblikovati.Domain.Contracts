namespace Oblikovati.Domain.Contracts;

public interface IMidpointConstraintProxy
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchPoint Point { get; }
    ISketchLine Line { get; }
    ISketchArc Arc { get; }
    IMidpointConstraint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
