namespace Oblikovati.Domain.Contracts;

public interface IParallelConstraint3D
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    object EntityOne { get; }
    object EntityTwo { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
