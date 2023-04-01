namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDSValue
{
    double ConstantValue { get; set; }
    IDSValueGraph Graph { get; }
    bool IsConstantValue { get; set; }
}