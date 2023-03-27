namespace Oblikovati.Domain.Contracts;

public interface IOffsetConstraint
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchEntity EntityOne { get; }
    ISketchEntity EntityTwo { get; }
    ISketchEntity EntityThree { get; }
    ISketchEntity EntityFour { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
