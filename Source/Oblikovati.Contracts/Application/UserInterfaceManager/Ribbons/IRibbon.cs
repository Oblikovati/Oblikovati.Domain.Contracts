namespace Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;

public interface IRibbon
{
    IUserInterfaceManager UserInterfaceManager { get; }
    string InternalName { get; }
    IRibbonTabs RibbonTabs { get; }
    bool Active { get; }
    ICommandControls QuickAccessControls { get; }
}