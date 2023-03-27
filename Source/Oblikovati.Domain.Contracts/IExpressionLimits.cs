using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IExpressionLimits
{

    string DefaultValue { get; set; }
    string IncrementValue { get; set; }
    string MaximumValue { get; set; }
    ComparisonTypeEnum MaximumValueComparisonType { get; set; }
    string MinimumValue { get; set; }
    ComparisonTypeEnum MinimumValueComparisonType { get; set; }
}
