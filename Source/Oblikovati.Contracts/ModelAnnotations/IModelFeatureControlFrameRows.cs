using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelFeatureControlFrameRows : IList<IModelFeatureControlFrameRows>
{
    IModelFeatureControlFrameRow Item { get; }


    IModelFeatureControlFrameRow Add(GeometricCharacteristicEnum GeometricCharacteristic, double Tolerance,
        GDTSymbolEnum ToleranceModifierPrefix, GDTSymbolEnum ToleranceMaterialCondition, object PrimaryDatumIdentifier,
        GDTSymbolEnum PrimaryDatumModifier, object SecondaryDatumIdentifier, GDTSymbolEnum SecondaryDatumModifier,
        object TertiaryDatumIdentifier, GDTSymbolEnum TertiaryDatumModifier);
}