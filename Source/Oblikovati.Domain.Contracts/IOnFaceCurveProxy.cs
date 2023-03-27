using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IOnFaceCurveProxy
{

    IAttributeSets AttributeSets { get; }
    bool Closed { get; set; }
    ISketchConstraints3DEnumerator Constraints3D { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    INameValueMap Faces { get; }
    int FitPointCount { get; }
    ISketchPoint3D StartSketchPoint { get; }
    ISketchPoint3D EndSketchPoint { get; }
    string Name { get; set; }
    ISketch3D Parent { get; }
    IBox RangeBox { get; }
    ISketchEntities3DEnumerator SketchEntities { get; }
    IOnFaceCurve NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void BreakLink();
    void Edit(INameValueMap Faces, INameValueMap FitPoints);
    void Delete();
    ISketchPoint3D FitPoint(int Index);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
