﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IHelicalCurve
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
    string Name { get; set; }
    IHelicalCurveDefinition Definition { get; set; }
    ISketchEntities3DEnumerator SketchEntities { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
