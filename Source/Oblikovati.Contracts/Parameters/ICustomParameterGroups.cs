namespace Oblikovati.Contracts.Parameters;

public interface ICustomParameterGroups : IList<ICustomParameterGroups>
{
    ICustomParameterGroup Item { get; }
    ICustomParameterGroup Add(string DisplayName, string InternalName, string ClientId);
}