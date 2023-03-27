﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAngularGeneralDimension
{
    bool ArrowheadsInside { get; set; }
    bool FirstArrowheadInside { get; set; }
    bool Retrieved { get; }
    bool SecondArrowheadInside { get; set; }
    IDimensionStyle Style { get; set; }
    bool _ShowLeader { get; }
    object RetrievedFrom { get; }
    GeneralDimensionTypeEnum GeneralDimensionType { get; }
    ArrowheadTypeEnum FirstArrowheadType { get; set; }
    ArrowheadTypeEnum SecondArrowheadType { get; set; }

    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool HideValue { get; set; }
    double ModelValue { get; }
    double OverrideModelValue { get; set; }
    bool ModelValueOverridden { get; set; }
    int Precision { get; set; }
    IDimensionText Text { get; set; }
    ITolerance Tolerance { get; }
    ILayer Layer { get; set; }
    bool Attached { get; }
    int TolerancePrecision { get; set; }
    object DimensionLine { get; }
    bool IsInspectionDimension { get; set; }
    IGeometryIntent IntentOne { get; set; }
    IGeometryIntent IntentTwo { get; set; }
    IGeometryIntent IntentThree { get; set; }
    bool ShowLeader { get; set; }
    bool UseQuadrant { get; set; }
    bool OppositeAngle { get; set; }
    AngularPrecisionEnum AngularPrecision { get; set; }
    AngularPrecisionEnum ToleranceAngularPrecision { get; set; }
    object ExtensionLineOne { get; }
    object ExtensionLineTwo { get; }
    bool ExtensionLineOneVisible { get; set; }
    bool ExtensionLineTwoVisible { get; set; }
    DimensionTypeEnum DimensionType { get; }
    bool HideSecondArrowhead { get; set; }
    IPoint2d SecondArrowheadPosition { get; set; }
    IDimensionConstraint PromoteToSketch();
    void ShowAllExtensionLines();
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape, string Label, string Rate);
    void CenterText();
}