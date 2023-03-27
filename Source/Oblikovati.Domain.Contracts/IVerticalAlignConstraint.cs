namespace Oblikovati.Domain.Contracts;

public interface IVerticalAlignConstraint
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchPoint PointOne { get; }
    ISketchPoint PointTwo { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
