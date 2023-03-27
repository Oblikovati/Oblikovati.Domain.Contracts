﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchControlPointSpline
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
    ISketchPoint ControlPoint { get; }
    int ControlPointCount { get; }
    ISketchLine ControlPolygonSide { get; }
    bool CurvatureDisplay { get; set; }
    ISketchPoint EndSketchPoint { get; }
    IBSplineCurve2d Geometry { get; }
    IBSplineCurve Geometry3d { get; }
    bool IsClosed { get; }
    double Length { get; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    double LineScale { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    IColor OverrideColor { get; set; }
    ISketchPoint StartSketchPoint { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    ISketchSpline ConvertToSpline();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void InsertKnot(double Position);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}