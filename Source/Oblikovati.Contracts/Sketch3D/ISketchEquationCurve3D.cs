﻿using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;
using Oblikovati.Contracts.Sketch3D.GeometricConstraints3D;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchEquationCurve3D
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
    bool CurvatureDisplay { get; set; }
    ISketchPoint3D EndSketchPoint { get; }
    IBSplineCurve Geometry { get; }
    double Length { get; }
    ISketchPoint3D StartSketchPoint { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);

    void GetEquation(out CoordinateSystemTypeEnum CoordinateSystemType, out string XValueOrRadius,
        out string YValueOrTheta, out string ZValueOrPhi, out IParameter MinValue, out IParameter MaxValue);

    void SetEquation(CoordinateSystemTypeEnum CoordinateSystemType, string XValueOrRadius, string YValueOrTheta,
        string ZValueOrPhi, object MinValue, object MaxValue);
}