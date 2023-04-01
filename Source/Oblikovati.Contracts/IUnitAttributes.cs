using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IUnitAttributes
{
    UnitsTypeEnum AlternateLinearUnits { get; set; }
    DecimalMarkerTypeEnum AlternateDecimalMarkerType { get; set; }
    bool AlternateUnitTypeDisplay { get; set; }
    bool AlternateLeadingZerosDisplay { get; set; }
    bool AlternateTrailingZerosDisplay { get; set; }
    LinearPrecisionEnum AlternateLinearPrecision { get; set; }
    bool UseStandardsNotation { get; set; }
    UnitsTypeEnum PrimaryLinearUnits { get; set; }
    DecimalMarkerTypeEnum PrimaryDecimalMarkerType { get; set; }
    bool PrimaryUnitTypeDisplay { get; set; }
    bool PrimaryLeadingZerosDisplay { get; set; }
    bool PrimaryTrailingZerosDisplay { get; set; }
    bool AlternateUnitsDisplay { get; set; }
    DimensionStyleFormatEnum DisplayStyleProp { get; set; }
}