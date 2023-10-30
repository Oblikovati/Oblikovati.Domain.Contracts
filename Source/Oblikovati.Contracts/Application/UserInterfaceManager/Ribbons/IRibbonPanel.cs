namespace Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;

public interface IRibbonPanel
{
    IRibbonTab Parent { get; }
    string DisplayName { get; }
    string InternalName { get; }
    ICommandControls CommandControls { get; }
    Guid? ClientId { get; }
    bool Visible { get; set; }
    bool Docked { get; set; }
    ICommandControls SlideoutControls { get; }
    string SlideOutKeyTip { get; set; }
    void Delete();
    void Reposition(string TargetPanelInternalName, bool InsertBeforeTargetPanel);
    void Move(int Top, int Left);
    void RefreshControls();
}