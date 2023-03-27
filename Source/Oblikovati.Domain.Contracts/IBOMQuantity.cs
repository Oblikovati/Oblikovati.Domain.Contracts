using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBOMQuantity
{

    IComponentDefinition Parent { get; }
    string BaseUnits { get; set; }
    string UnitQuantity { get; }
    void GetBaseQuantity(out BOMQuantityTypeEnum QuantityType, out object Quantity);
    void SetBaseQuantity(BOMQuantityTypeEnum QuantityType, object Quantity);
    double GetEvaluatedBaseQuantity(out BOMQuantityTypeEnum QuantityType);
}
