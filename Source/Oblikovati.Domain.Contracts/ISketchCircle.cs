﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchCircle
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
    ISketchPoint CenterSketchPoint { get; }
    double Radius { get; set; }
    ICircle2d Geometry { get; }
    double Area { get; }
    IColor OverrideColor { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    double LineScale { get; set; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    bool CurvatureDisplay { get; set; }
    double Length { get; }
    ICircle Geometry3d { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}