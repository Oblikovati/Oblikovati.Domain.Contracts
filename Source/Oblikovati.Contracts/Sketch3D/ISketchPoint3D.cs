﻿using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Sketch3D.GeometricConstraints3D;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchPoint3D
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
    IPoint Geometry { get; set; }
    ISketchEntities3DEnumerator AttachedEntities { get; }
    bool HoleCenter { get; set; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void ConnectTo(object ConstrainingPoint);
    void MoveBy(IVector Vector);
    void MoveTo(IPoint Point);
}