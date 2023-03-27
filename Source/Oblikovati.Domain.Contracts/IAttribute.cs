using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAttribute
{

    string Name { get; set; }
    object Value { get; set; }
    ValueTypeEnum ValueType { get; }
    void Delete();
}
