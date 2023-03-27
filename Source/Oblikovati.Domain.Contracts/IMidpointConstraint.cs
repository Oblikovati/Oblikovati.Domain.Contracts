namespace Oblikovati.Domain.Contracts;

public interface IMidpointConstraint
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchPoint Point { get; }
    ISketchLine Line { get; }
    ISketchArc Arc { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
