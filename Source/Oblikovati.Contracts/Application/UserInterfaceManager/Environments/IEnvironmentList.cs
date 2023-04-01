namespace Oblikovati.Contracts.Application.UserInterfaceManager.Environments;

public interface IEnvironmentList : IList<IEnvironment>
{
    void Remove(int Index);
}