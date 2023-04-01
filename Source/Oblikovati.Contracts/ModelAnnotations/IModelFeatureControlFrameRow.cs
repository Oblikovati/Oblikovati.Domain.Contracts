using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelFeatureControlFrameRow
{
    IModelFeatureControlFrameDefinition Parent { get; }
    GeometricCharacteristicEnum GeometricCharacteristic { get; set; }
    double Tolerance { get; set; }
    IModelDatumIdentifier PrimaryDatumIdentifier { get; set; }
    GDTSymbolEnum PrimaryDatumModifier { get; set; }
    IModelDatumIdentifier SecondaryDatumIdentifier { get; set; }
    GDTSymbolEnum SecondaryDatumModifier { get; set; }
    IModelDatumIdentifier TertiaryDatumIdentifier { get; set; }
    GDTSymbolEnum TertiaryDatumModifier { get; set; }
    GDTSymbolEnum ToleranceModifierPrefix { get; set; }
    GDTSymbolEnum ToleranceMaterialCondition { get; set; }
    bool DisplayTangentPlaneModifier { get; set; }
    bool DisplayFreeStateModifier { get; set; }
    bool DisplayStatisticalModifier { get; set; }
    bool DisplayProjectedToleranceZoneModifier { get; set; }
    bool DisplayUnequallyDisposedModifier { get; set; }
    double ProjectedToleranceZoneValue { get; set; }
    double UnequallyDisposedValue { get; set; }
    IModelDatumIdentifier PrimaryCompoundDatumIdentifier { get; set; }
    GDTSymbolEnum PrimaryCompoundDatumModifier { get; set; }
    IModelDatumIdentifier SecondaryCompoundDatumIdentifier { get; set; }
    GDTSymbolEnum SecondaryCompoundDatumModifier { get; set; }
    IModelDatumIdentifier TertiaryCompoundDatumIdentifier { get; set; }
    GDTSymbolEnum TertiaryCompoundDatumModifier { get; set; }
    bool GeneralProfileOfSurfaceModifier { get; set; }
    short TolerancePrecision { get; set; }
    short ProjectedToleranceZonePrecision { get; set; }
    short UnequallyDisposedPrecision { get; set; }
    string InternalName { get; }
    void Delete();
    void GenerateInternalName(object Context, object InternalName);
}