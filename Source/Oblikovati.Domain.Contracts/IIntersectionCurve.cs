namespace Oblikovati.Domain.Contracts;

public interface IIntersectionCurve
{

    IAttributeSets AttributeSets { get; }
    object EntityOne { get; set; }
    object EntityTwo { get; set; }
    string Name { get; set; }
    ISketch3D Parent { get; }
    ISketchEntities3DEnumerator SketchEntities { get; }
    void BreakLink();
    void Delete();
    IIntersectionCurve Edit(object EntityOne, object EntityTwo);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
