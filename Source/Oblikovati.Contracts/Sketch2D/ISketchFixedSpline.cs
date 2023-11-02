﻿using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Sketch2D.DimensionConstraints;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchFixedSpline
{
    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    object ReferencedEntity { get; }
    IBox2d RangeBox { get; }
    ISketchConstraintsEnumerator Constraints { get; }
    bool Reference { get; set; }
    bool Construction { get; set; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    ILayer Layer { get; set; }
    GeometryMoveableStatusEnum _GeometryMoveableStatus { get; }
    ISketchEntitiesEnumerator OwnedBy { get; }
    bool SketchOnly { get; set; }
    ISketchBlock ContainingSketchBlock { get; }
    ISketchBlocksEnumerator SketchBlockPath { get; }
    IBSplineCurve2d Geometry { get; }
    double Length { get; }
    ISketchPoint StartSketchPoint { get; }
    ISketchPoint EndSketchPoint { get; }
    bool Closed { get; }
    IColor OverrideColor { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    double LineScale { get; set; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    IBSplineCurve Geometry3d { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Edit(IBSplineCurve2d SplineCurve, object StartPoint, object EndPoint);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    ISketchSpline ConvertToSpline();
}