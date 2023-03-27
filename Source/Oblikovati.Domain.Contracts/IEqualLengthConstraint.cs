namespace Oblikovati.Domain.Contracts;

public interface IEqualLengthConstraint
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchLine LineOne { get; }
    ISketchLine LineTwo { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
