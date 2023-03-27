namespace Oblikovati.Domain.Contracts;

//TODO: Does it make sense to keep this with dotnet?
public interface INameValueMap : IReadOnlyDictionary<string, object>
{
    void Remove(object Index);
    void Insert(string Name, object Value, object TargetIndex, bool InsertBefore);
}
