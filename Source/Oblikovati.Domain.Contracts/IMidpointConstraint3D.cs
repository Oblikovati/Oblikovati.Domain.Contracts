namespace Oblikovati.Domain.Contracts;

public interface IMidpointConstraint3D
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchLine3D Line { get; }
    ISketchPoint3D Point { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
