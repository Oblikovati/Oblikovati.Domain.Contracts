using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch3D.GeometricConstraints3D;

public interface IOnFaceConstraint3D
{
    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchEntity3D Entity { get; }
    object Face { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}