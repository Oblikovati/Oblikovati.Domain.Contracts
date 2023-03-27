namespace Oblikovati.Domain.Contracts;

public interface ICommandCategory : IList<object>
{
    ICommandManager Parent { get; }
    bool BuiltIn { get; }
    string DisplayName { get; }
    string InternalName { get; }
    string ClientId { get; }
    void Delete();
    void Remove(int Index);
}
