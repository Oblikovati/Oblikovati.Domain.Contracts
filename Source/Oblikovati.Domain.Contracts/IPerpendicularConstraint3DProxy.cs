namespace Oblikovati.Domain.Contracts;

public interface IPerpendicularConstraint3DProxy
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    object EntityOne { get; }
    object EntityTwo { get; }
    IPerpendicularConstraint3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
