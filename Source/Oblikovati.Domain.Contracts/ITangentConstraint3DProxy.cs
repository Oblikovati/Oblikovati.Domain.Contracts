namespace Oblikovati.Domain.Contracts;

public interface ITangentConstraint3DProxy
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchEntity3D EntityOne { get; }
    ISketchEntity3D EntityTwo { get; }
    ITangentConstraint3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void FlipDirection();
}
