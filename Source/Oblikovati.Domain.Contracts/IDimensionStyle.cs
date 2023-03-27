using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDimensionStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    DecimalMarkerTypeEnum AlternateDecimalMarkerType { get; set; }
    bool AlternateDisplayUnitType { get; set; }
    bool AlternateLeadingZeroDisplay { get; set; }
    LinearPrecisionEnum AlternateLinearPrecision { get; set; }
    UnitsTypeEnum AlternateLinearUnits { get; set; }
    DimensionStyleFormatEnum AlternateStyleFormat { get; set; }
    bool AlternateTrailingZeroDisplay { get; set; }
    bool AlternateUnitsDisplay { get; set; }
    AngularPrecisionEnum AngularPrecision { get; set; }
    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    bool DisplayUnitType { get; set; }
    bool _InUse { get; }
    bool LeadingZeroDisplay { get; set; }
    LinearPrecisionEnum LinearPrecision { get; set; }
    UnitsTypeEnum LinearUnits { get; set; }
    StyleLocationEnum _StyleLocation { get; }
    string _Name { get; set; }
    string Prefix { get; set; }
    PrefixAndSuffixOrderEnum PrefixAndSuffixOrder { get; set; }
    string Suffix { get; set; }
    ITextStyle TextStyle { get; set; }
    ITolerance Tolerance { get; }
    int ToleranceAlternateUnitPrecision { get; set; }
    int _ToleranceAngularPrecision { get; set; }
    double ToleranceFontSize { get; set; }
    bool ToleranceLeadingZeroDisplay { get; set; }
    int ToleranceLinearPrecision { get; set; }
    ITextStyle ToleranceTextStyle { get; set; }
    bool ToleranceTrailingZeroDisplay { get; set; }
    bool TrailingZeroDisplay { get; set; }
    string _InternalName { get; }
    bool _UpToDate { get; }
    AngularPrecisionEnum ToleranceAngularPrecision { get; set; }
    ILeaderStyle LeaderStyle { get; set; }
    DisplayFormatEnum DisplayFormat { get; set; }
    double FractionalTextScale { get; set; }
    DisplayFormatEnum AlternateDisplayFormat { get; set; }
    double AlternateFractionalTextScale { get; set; }
    double ArrowheadHeight { get; set; }
    double ArrowheadSize { get; set; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    IColor Color { get; set; }
    double Extension { get; set; }
    double Gap { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    double OriginOffset { get; set; }
    double PartOffset { get; set; }
    bool ShowBreakSymbol { get; set; }
    bool ShowDimensionLine { get; set; }
    double Spacing { get; set; }
    ArrowheadTypeEnum ArrowheadTypeForChainDimensions { get; set; }
    bool AlternateIncludedZeroDisplay { get; set; }
    bool IncludedZeroDisplay { get; set; }
    bool ToleranceAlternateIncludedZeroDisplay { get; set; }
    bool ToleranceAlternateLeadingZeroDisplay { get; set; }
    bool ToleranceAlternateTrailingZeroDisplay { get; set; }
    bool ToleranceIncludedZeroDisplay { get; set; }
    ArrowheadTypeEnum OrdinateDimensionOriginArrowheadType { get; set; }
    bool AngularFormatIsDecimalDegrees { get; set; }
    bool AngularLeadingZeroDisplay { get; set; }
    bool AngularTrailingZeroDisplay { get; set; }
    DimensionTextOrientationEnum AlignedDimensionTextOrientation { get; set; }
    bool AngularArrowsInside { get; set; }
    bool AngularHideExtensionLineOne { get; set; }
    bool AngularHideExtensionLineTwo { get; set; }
    DimensionTextModifierEnum AngularTextModifier { get; set; }
    DimensionTextOrientationEnum AngularTextOrientation { get; set; }
    bool BasicDimensionPrefixSuffixInside { get; set; }
    DimensionStyleFormatEnum BendNoteDualFormat { get; set; }
    DimensionStyleFormatEnum ChamferNoteDualFormat { get; set; }
    bool DiameterArrowsInside { get; set; }
    bool DiameterDualDimensionLine { get; set; }
    DimensionTextOrientationEnum DiameterExternalTextOrientation { get; set; }
    DimensionTextOrientationEnum DiameterInternalTextOrientation { get; set; }
    bool DiameterLeaderFromCenter { get; set; }
    MultiLineDimensionTextEnum DiameterMultiLineTextOrientation { get; set; }
    bool DiameterShowDiameterSymbol { get; set; }
    bool AngularUseQuadrant { get; set; }
    DimensionStyleFormatEnum DimensionDualFormat { get; set; }
    MultiLineDimensionTextEnum LinearMultiLineTextOrientation { get; set; }
    DimensionStyleFormatEnum HoleNoteDualFormat { get; set; }
    DimensionTextOrientationEnum HorizontalDimensionTextOrientation { get; set; }
    bool LinearArrowsInside { get; set; }
    bool LinearHideExtensionLineOne { get; set; }
    bool LinearHideExtensionLineTwo { get; set; }
    OrdinateDimensionAlignmentEnum OrdinateAlignment { get; set; }
    bool OrdinateHideOriginIndicator { get; set; }
    bool OrdinateJoggingAllowed { get; set; }
    bool OrdinatePositiveBothDirections { get; set; }
    bool OrdinateShowDirection { get; set; }
    bool OrdinateUseOriginIndicator { get; set; }
    DimensionStyleFormatEnum PunchNoteDualFormat { get; set; }
    bool RadialArrowsInside { get; set; }
    bool RadialJoggedLeader { get; set; }
    bool RadialLeaderFromCenter { get; set; }
    MultiLineDimensionTextEnum RadialMultiLineTextOrientation { get; set; }
    DimensionTextOrientationEnum RadialTextOrientation { get; set; }
    VerticalTextAlignmentEnum ToleranceJustification { get; set; }
    bool ToleranceShowMinuteSecond { get; set; }
    DimensionZeroToleranceDisplayEnum ToleranceZeroToleranceDisplay { get; set; }
    DimensionTextOrientationEnum VerticalDimensionTextOrientation { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IDimensionStyle _Copy(string Name);
    void _Delete();
    IDimensionStyle _ConvertToLocal();
    void _SaveToGlobal();
    void _UpdateFromGlobal();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
