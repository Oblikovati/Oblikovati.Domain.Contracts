using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelFeatureControlFrameRows : IList<IModelFeatureControlFrameRows>
{

    IModelFeatureControlFrameRow Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IModelFeatureControlFrameRow Add(GeometricCharacteristicEnum GeometricCharacteristic, double Tolerance, GDTSymbolEnum ToleranceModifierPrefix, GDTSymbolEnum ToleranceMaterialCondition, object PrimaryDatumIdentifier, GDTSymbolEnum PrimaryDatumModifier, object SecondaryDatumIdentifier, GDTSymbolEnum SecondaryDatumModifier, object TertiaryDatumIdentifier, GDTSymbolEnum TertiaryDatumModifier);
}
