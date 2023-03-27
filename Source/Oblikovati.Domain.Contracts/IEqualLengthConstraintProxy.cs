namespace Oblikovati.Domain.Contracts;

public interface IEqualLengthConstraintProxy
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchLine LineOne { get; }
    ISketchLine LineTwo { get; }
    IEqualLengthConstraint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
