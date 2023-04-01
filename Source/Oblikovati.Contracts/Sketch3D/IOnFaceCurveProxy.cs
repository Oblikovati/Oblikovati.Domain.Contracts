using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch3D.GeometricConstraints3D;

namespace Oblikovati.Contracts.Sketch3D;

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