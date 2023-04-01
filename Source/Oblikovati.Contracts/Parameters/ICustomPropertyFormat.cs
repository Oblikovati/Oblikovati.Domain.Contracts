using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Parameters;

public interface ICustomPropertyFormat
{
    IParameter Parent { get; }
    CustomPropertyTypeEnum PropertyType { get; set; }
    string Units { get; set; }
    CustomPropertyPrecisionEnum Precision { get; set; }
    bool ShowLeadingZeros { get; set; }
    bool ShowTrailingZeros { get; set; }
    bool ShowUnitsString { get; set; }
}