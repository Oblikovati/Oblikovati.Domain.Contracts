namespace Oblikovati.Domain.Contracts;

public interface IBendConstraint
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchArc3D Arc { get; }
    ISketchLine3D LineOne { get; }
    ISketchLine3D LineTwo { get; }
    IParameter Radius { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
