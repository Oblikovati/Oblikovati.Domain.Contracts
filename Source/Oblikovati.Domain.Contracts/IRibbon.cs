namespace Oblikovati.Domain.Contracts;

public interface IRibbon
{
    IUserInterfaceManager Parent { get; }
    string InternalName { get; }
    IRibbonTabs RibbonTabs { get; }
    bool Active { get; }
    ICommandControls QuickAccessControls { get; }
}
