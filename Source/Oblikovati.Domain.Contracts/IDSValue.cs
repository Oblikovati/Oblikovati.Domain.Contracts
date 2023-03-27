namespace Oblikovati.Domain.Contracts;

public interface IDSValue
{

    double ConstantValue { get; set; }
    IDSValueGraph Graph { get; }
    bool IsConstantValue { get; set; }
}
