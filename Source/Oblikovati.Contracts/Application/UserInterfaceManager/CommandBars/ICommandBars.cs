using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;

public interface ICommandBars : IList<ICommandBar>
{
    public ICommandBar this[string Index] { get; }
    ICommandBar Add(string DisplayName, string InternalName, CommandBarTypeEnum CommandBarType, object ClientId);
}