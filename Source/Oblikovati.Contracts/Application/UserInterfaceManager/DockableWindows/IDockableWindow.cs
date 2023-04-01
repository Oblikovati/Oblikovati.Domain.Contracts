using Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.DockableWindows;

public interface IDockableWindow
{
    string ClientId { get; }
    object Control { get; }
    DockingStateEnum DisabledDockingStates { get; set; }
    DockingStateEnum DockingState { get; set; }
    int Height { get; set; }
    int HWND { get; }
    string InternalName { get; }
    int Left { get; }
    IUserInterfaceManager Parent { get; }
    string Title { get; set; }
    string Caption { get; set; }
    bool ShowTitleBar { get; set; }
    int Top { get; }
    bool Visible { get; set; }
    int Width { get; set; }
    bool IsCustomized { get; }
    IControlDefinition VisibilityControl { get; }
    bool ShowVisibilityCheckBox { get; set; }
    bool DisableCloseButton { get; set; }
    void AddChild(object Identifier);
    void Clear();
    void Delete();
    void Delete2(bool SaveCurrentStates);
    void Move(int Top, int Left, int Height, int Width);
    void SetMinimumSize(int Height, int Width);
    void GetDockingState(out DockingStateEnum DockingState, out object DockToObject);
    void SetDockingState(DockingStateEnum DockingState, object DockToObject);
}