using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;

public interface IiFeatureParameterInput
{
    string Prompt { get; }
    string Name { get; }
    iFeatureEntityInputTypeEnum EntityType { get; }
    IParameter Parameter { get; }
    string DefaultExpression { get; }
    string Expression { get; set; }
    bool IsPunchToolDepth { get; }
    int LimitListCount { get; }
    iFeatureParamLimitTypeEnum LimitType { get; }
    double Value { get; set; }
    string LimitListExpressions(int Index);

    void LimitRangeExpressions(out string LeftLimitValue, out string LeftRangeSpec, out string RightRangeSpec,
        out string RightLimitValue);
}