using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ContentCenter;

public interface IExpressionLimits
{
    string DefaultValue { get; set; }
    string IncrementValue { get; set; }
    string MaximumValue { get; set; }
    ComparisonTypeEnum MaximumValueComparisonType { get; set; }
    string MinimumValue { get; set; }
    ComparisonTypeEnum MinimumValueComparisonType { get; set; }
}