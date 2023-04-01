namespace Oblikovati.Contracts.Application.ChangeManager;

public interface IChangeManager : IList<IChangeDefinitions>, IInjectableSingletonEntity
{
    IChangeDefinitions Add(string ClientId);
    object GetObjectFromScriptKey(string ScriptKey);
    string GetScriptKeyFromObject(object Object);
}