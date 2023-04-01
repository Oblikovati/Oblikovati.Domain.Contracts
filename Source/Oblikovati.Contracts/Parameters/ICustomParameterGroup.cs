using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Parameters;

public interface ICustomParameterGroup : IList<ICustomParameterGroup>
{
    string ClientId { get; }

    ActionTypeEnum DisabledActionTypes { get; set; }
    string DisplayName { get; set; }
    string InternalName { get; }
    IParameter Item { get; }
    void Add(IParameter Parameter);
    void Delete(bool DeleteParameters);
    void Remove(int Index);
}