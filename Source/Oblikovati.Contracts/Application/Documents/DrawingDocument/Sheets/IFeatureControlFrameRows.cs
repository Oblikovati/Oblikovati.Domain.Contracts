using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets;

public interface IFeatureControlFrameRows : IList<IFeatureControlFrameRows>
{
    IFeatureControlFrameRow Item { get; }


    IFeatureControlFrameRow Add(GeometricCharacteristicEnum GeometricCharacteristic, string Tolerance,
        string LowerTolerance, string DatumOne, string DatumTwo, string DatumThree);
}