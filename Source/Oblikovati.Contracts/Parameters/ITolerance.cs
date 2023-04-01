using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Parameters;

public interface ITolerance
{
    ToleranceTypeEnum ToleranceType { get; }
    double Upper { get; }
    double Lower { get; }
    string HoleTolerance { get; }
    string ShaftTolerance { get; }
    void SetToDefault();
    void SetToDeviation(object UpperTolerance, object LowerTolerance);
    void SetToFits(ToleranceTypeEnum FitsToleranceType, string HoleTolerance, string ShaftTolerance);
    void _SetToLimits(object UpperTolerance, object LowerTolerance);
    void SetToLimits(ToleranceTypeEnum LimitsToleranceType, object UpperTolerance, object LowerTolerance);
    void SetToMinMax(ToleranceTypeEnum MinMaxToleranceType, object DeviationValue);
    void SetToShowFits(ToleranceTypeEnum FitsToleranceType, string HoleOrShaftTolerance);
    void SetToSymmetric(object Tolerance);
    void SetToMin();
    void SetToMax();
    void SetToBasic();
    void SetToReference();
}