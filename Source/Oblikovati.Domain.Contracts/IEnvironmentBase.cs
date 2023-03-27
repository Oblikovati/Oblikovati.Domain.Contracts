namespace Oblikovati.Domain.Contracts;

public interface IEnvironmentBase
{
    string InternalName { get; }
    string DisplayName { get; }
    ICommandBarBase DefaultToolBar { get; set; }
    ICommandBarBase DefaultPanelBar { get; set; }
    ICommandBarList PanelBarList { get; }
    ICommandBarBase MenuBar { get; }
    ICommandBarBase CurrentPanelBar { get; set; }
}
