namespace Oblikovati.Contracts.Application.ChangeManager;

public interface IChangeDefinitions : IList<IChangeDefinition>
{
    string ClientId { get; }
    IChangeDefinition Add(string InternalName, string CommandName);
    void Delete();
}