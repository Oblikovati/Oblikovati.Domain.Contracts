using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Parameters;

public interface IDerivedParameter
{
    ParameterTypeEnum ParameterType { get; }
    string Comment { get; set; }
    IObjectCollection Dependents { get; }
    IObjectCollection DrivenBy { get; }
    string Name { get; set; }
    string Expression { get; set; }
    double _Value { get; set; }
    object Value { get; set; }
    string Units { get; set; }
    bool IsKey { get; set; }
    IExpressionList ExpressionList { get; }
    HealthStatusEnum HealthStatus { get; }
    IAttributeSets AttributeSets { get; }
    bool ExposedAsProperty { get; set; }
    ITolerance Tolerance { get; }
    double ModelValue { get; }
    ModelValueTypeEnum ModelValueType { get; set; }
    int Precision { get; set; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    bool Visible { get; set; }
    bool InUse { get; }
    ICustomPropertyFormat CustomPropertyFormat { get; }
    ParameterDisplayFormatEnum DisplayFormat { get; set; }
    IParameter ReferencedEntity { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}