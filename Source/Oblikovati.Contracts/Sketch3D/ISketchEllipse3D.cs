﻿using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Sketch3D.GeometricConstraints3D;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchEllipse3D
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
    IPoint CenterPoint { get; }
    IEllipseFull Geometry { get; set; }
    double Area { get; }
    bool CurvatureDisplay { get; set; }
    double Length { get; }
    double MajorRadius { get; }
    double MinorRadius { get; }
    IUnitVector MajorAxisVector { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}