namespace Oblikovati.Domain.Contracts;

public interface IEqualConstraint3D
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchEntity3D EntityOne { get; }
    ISketchEntity3D EntityTwo { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
