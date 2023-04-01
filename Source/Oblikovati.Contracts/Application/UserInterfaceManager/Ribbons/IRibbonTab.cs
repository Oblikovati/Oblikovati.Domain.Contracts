namespace Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;

public interface IRibbonTab
{
    IRibbon Parent { get; }
    string DisplayName { get; }
    string InternalName { get; }
    IRibbonPanels RibbonPanels { get; }
    bool Active { get; }
    string ClientId { get; }
    bool Visible { get; set; }
    bool Contextual { get; }
    string KeyTip { get; set; }
    void Delete();
}