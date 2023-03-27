using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICustomParameterGroup : IList<ICustomParameterGroup>
{

    string ClientId { get; }
    int Count { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    string DisplayName { get; set; }
    string InternalName { get; }
    IParameter Item { get; }
    void Add(IParameter Parameter);
    void Delete(bool DeleteParameters);
    void Remove(int Index);
    IEnumerator GetEnumerator();
}
