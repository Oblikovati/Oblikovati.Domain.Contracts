using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICommandBars : IList<ICommandBar>
{
    public ICommandBar this[string Index] { get; }
    ICommandBar Add(string DisplayName, string InternalName, CommandBarTypeEnum CommandBarType, object ClientId);
}
