using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IUnitsFormatting
{


    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    DisplayFormatEnum DisplayFormat { get; set; }
    double FractionalTextScale { get; set; }
    CustomPropertyPrecisionEnum Precision { get; set; }
    bool ShowUnitString { get; set; }
    UnitsTypeEnum Units { get; set; }
    ValueUnitsTypeEnum UnitType { get; set; }
}
