namespace Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;

public interface ICommandBarBase
{
    ICommandBarControls Controls { get; }
    string DisplayName { get; }
    string InternalName { get; }
    ICommandBarBase Copy(string DisplayName, object InternalName);
    void _Remove(string InternalName);
}