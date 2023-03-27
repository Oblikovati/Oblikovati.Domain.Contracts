namespace Oblikovati.Domain.Contracts;

public interface IVerticalAlignConstraintProxy
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchPoint PointOne { get; }
    ISketchPoint PointTwo { get; }
    IVerticalAlignConstraint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
