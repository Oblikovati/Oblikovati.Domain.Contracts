namespace Oblikovati.Domain.Contracts;

public interface IParallelToXAxisConstraint3DProxy
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchLine3D Line { get; }
    IParallelToXAxisConstraint3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
