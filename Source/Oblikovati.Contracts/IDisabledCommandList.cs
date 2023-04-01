using Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;

namespace Oblikovati.Contracts;

public interface IDisabledCommandList : IList<IDisabledCommandList>
{
    IControlDefinition Item { get; }

    void Add(IControlDefinition Command);
    void Remove(int Index);
}