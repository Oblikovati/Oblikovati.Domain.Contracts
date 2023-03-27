namespace Oblikovati.Domain.Contracts;

public interface IEnvironmentList : IList<IEnvironment>
{
    void Add(IEnvironment Environment);
    void Remove(int Index);
}
