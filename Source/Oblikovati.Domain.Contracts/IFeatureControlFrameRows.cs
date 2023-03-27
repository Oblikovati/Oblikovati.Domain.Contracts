using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFeatureControlFrameRows : IList<IFeatureControlFrameRows>
{

    IFeatureControlFrameRow Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IFeatureControlFrameRow Add(GeometricCharacteristicEnum GeometricCharacteristic, string Tolerance, string LowerTolerance, string DatumOne, string DatumTwo, string DatumThree);
}
