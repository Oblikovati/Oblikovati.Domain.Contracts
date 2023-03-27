using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFeatureControlFrameStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    GeometricCharacteristicEnum AvailableGeometricCharacteristics { get; set; }
    MaterialRemovalModifierEnum AvailableModifiers { get; set; }
    bool MergeSymbol { get; set; }
    bool MergeTolerance { get; set; }
    bool MergeDatum { get; set; }
    bool AlignCellsVertically { get; set; }
    bool AllowTolerance2 { get; set; }
    ILeaderStyle LeaderStyle { get; set; }
    ITextStyle TextStyle { get; set; }
    bool ScaleToTextHeight { get; set; }
    double Size { get; set; }
    double WhiteSpace { get; set; }
    UnitsTypeEnum LinearUnits { get; set; }
    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    bool DisplayUnitType { get; set; }
    bool LeadingZeroDisplay { get; set; }
    bool TrailingZeroDisplay { get; set; }
    bool AlternateUnitsDisplay { get; set; }
    AlternateUnitsDisplayTypeEnum AlternateUnitsDisplayType { get; set; }
    UnitsTypeEnum AlternateLinearUnits { get; set; }
    DecimalMarkerTypeEnum AlternateDecimalMarkerType { get; set; }
    bool AlternateDisplayUnitType { get; set; }
    bool AlternateLeadingZeroDisplay { get; set; }
    bool AlternateTrailingZeroDisplay { get; set; }
    LinearPrecisionEnum AlternateLinearPrecision { get; set; }
    bool AttachLeaderToCorner { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void GetAvailableAdditionalSymbols(out List<FeatureControlFrameAdditionalSymbolsEnum> AvailaleAdditionalSymbols);
    void SetAvailableAdditionalSymbols(List<FeatureControlFrameAdditionalSymbolsEnum> AvailaleAdditionalSymbols);
}
