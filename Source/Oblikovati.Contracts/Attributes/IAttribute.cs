using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Attributes;

public interface IAttribute
{
    string Name { get; set; }
    object Value { get; set; }
    ValueTypeEnum ValueType { get; }
    void Delete();
}