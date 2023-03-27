namespace Oblikovati.Domain.Contracts;

public interface ISplineFitPointConstraintProxy
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchSpline Spline { get; }
    ISketchPoint Point { get; }
    ISplineFitPointConstraint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
