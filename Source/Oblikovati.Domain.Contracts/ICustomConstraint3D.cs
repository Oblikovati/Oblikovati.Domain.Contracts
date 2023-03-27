namespace Oblikovati.Domain.Contracts;

public interface ICustomConstraint3D
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchEntity3D Entity { get; }
    string ClientId { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
