using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.BOM;

public interface IBOMQuantity
{
    IComponentDefinition Parent { get; }
    string BaseUnits { get; set; }
    string UnitQuantity { get; }
    void GetBaseQuantity(out BOMQuantityTypeEnum QuantityType, out object Quantity);
    void SetBaseQuantity(BOMQuantityTypeEnum QuantityType, object Quantity);
    double GetEvaluatedBaseQuantity(out BOMQuantityTypeEnum QuantityType);
}