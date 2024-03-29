﻿using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch3D;

namespace Oblikovati.Contracts.NotClassified;

public interface IWorkPoint
{
    bool Adaptive { get; set; }

    IComponentDefinition Parent { get; }
    bool Construction { get; }
    object Definition { get; }
    WorkPointDefinitionEnum DefinitionType { get; }
    IObjectCollection Dependents { get; }
    IObjectCollection DrivenBy { get; }
    bool Grounded { get; set; }
    string Name { get; set; }
    IPoint Point { get; }
    bool Visible { get; set; }
    HealthStatusEnum HealthStatus { get; }
    IAttributeSets AttributeSets { get; }
    IWorkPoint ReferencedEntity { get; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    bool IsPatternElement { get; }
    bool Shared { get; set; }
    bool Consumed { get; }
    bool ConsumeInputs { get; set; }
    bool IsOwnedByFeature { get; }
    IPartFeature OwnedBy { get; }
    bool IsParentSketch { get; }
    ISketch3D ParentSketch { get; }
    bool IsCoordinateSystemElement { get; }
    bool Exported { get; set; }
    void Delete(bool RetainDependents);
    void SetByThreePlanes(object Plane1, object Plane2, object Plane3);
    void SetByTwoLines(object Line1, object Line2);
    void SetByCurveAndEntity(object Curve, object Entity, object ProximityPoint);
    void SetByPoint(object Point);
    void SetByMidPoint(IEdge Edge);
    void SetFixed(IPoint Point);
    void SetByTorusCenterPoint(IFace Face);
    void SetBySphereCenterPoint(IFace Face);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetEndOfPart(bool Before);
    void SetAtCentroid(object Entities);
}