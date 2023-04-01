using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets;

public interface IFeatureControlFrameRow
{
    IFeatureControlFrame Parent { get; }
    GeometricCharacteristicEnum GeometricCharacteristic { get; set; }
    string Tolerance { get; set; }
    string LowerTolerance { get; set; }
    string DatumOne { get; set; }
    string DatumTwo { get; set; }
    string DatumThree { get; set; }
    void Delete();
}