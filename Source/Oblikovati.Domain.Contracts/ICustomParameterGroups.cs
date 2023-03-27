namespace Oblikovati.Domain.Contracts;

public interface ICustomParameterGroups : IList<ICustomParameterGroups>
{

    int Count { get; }
    ICustomParameterGroup Item { get; }
    ICustomParameterGroup Add(string DisplayName, string InternalName, string ClientId);
    IEnumerator GetEnumerator();
}
