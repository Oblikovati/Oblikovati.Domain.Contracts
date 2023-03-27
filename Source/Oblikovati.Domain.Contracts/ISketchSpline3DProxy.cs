﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchSpline3DProxy
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    ISketchConstraints3DEnumerator Constraints3D { get; }
    bool HasReferenceComponent { get; }
    IBox RangeBox { get; }
    bool Reference { get; set; }
    object ReferencedEntity { get; }
    IReferenceComponent ReferenceComponent { get; }
    bool Construction { get; set; }
    ISketchEntities3DEnumerator OwnedBy { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    int AssociativeID { get; }
    GeometryMoveableStatusEnum _GeometryMoveableStatus { get; }
    ISketchPoint3D EndSketchPoint { get; }
    ISketchPoint3D StartSketchPoint { get; }
    IBSplineCurve Geometry { get; set; }
    double Length { get; }
    bool Closed { get; set; }
    bool CurvatureDisplay { get; set; }
    SplineFitMethodEnum FitMethod { get; set; }
    int FitPointCount { get; }
    ISketchPoint3D FitPoint { get; }
    IParameter StartTangentScale { get; }
    IParameter EndTangentScale { get; }
    int Tension { get; set; }
    ISketchSpline3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    ISketchPoint3D InsertFitPoint(object FitPoint, int TargetIndex, bool InsertBefore);
    ISketchSpline3D Split(object FitPoint);
    void Disconnect(object FitPoint);
    bool GetHandleStatus(ISketchPoint3D FitPoint);
    void SetHandleStatus(ISketchPoint3D FitPoint, bool Value);
    ISketchSplineHandle3D GetHandle(ISketchPoint3D FitPoint);
}
