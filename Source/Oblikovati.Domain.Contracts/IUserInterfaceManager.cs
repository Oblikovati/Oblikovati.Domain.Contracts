using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IUserInterfaceManager : IInjectableSingletonEntity
{
    ICommandBars CommandBars { get; }
    IEnvironment ActiveEnvironment { get; set; }
    IEnvironmentList ParallelEnvironments { get; }
    IEnvironments Environments { get; }
    bool ShowBrowser { get; set; }
    bool ExpertMode { get; set; }
    bool LargeIcons { get; set; }
    bool ShowPanelBar { get; set; }
    bool ShowToolBar { get; set; }
    bool ShowStatusBar { get; set; }
    bool ProgressBarEnabled { get; set; }
    bool UserInteractionDisabled { get; set; }
    IUserInterfaceEvents UserInterfaceEvents { get; }
    bool CapacityMeterEnabled { get; set; }
    IRibbons Ribbons { get; }
    ICommandControls FileBrowserControls { get; }
    RibbonAppearanceEnum RibbonAppearance { get; set; }
    RibbonDockingStateEnum RibbonDockingState { get; set; }
    RibbonStateEnum RibbonState { get; set; }
    bool ShowCleanScreen { get; set; }
    bool ShowDocumentTabs { get; set; }
    bool ShowPanelTitles { get; set; }
    bool ShowQuickAccessControlsBelowRibbon { get; set; }
    ICommandControls HelpControls { get; }
    InterfaceStyleEnum InterfaceStyle { get; }
    IDockableWindows DockableWindows { get; }
    bool ShowNavigationBar { get; set; }
    bool ShowSteeringWheel { get; set; }
    bool ShowViewCube { get; set; }
    IBalloonTips BalloonTips { get; }
    bool ShowMarkingMenu { get; set; }
    OverflowMenuBehaviorEnum OverflowMenuBehavior { get; set; }
    bool PinMiniToolbarPosition { get; }
    void DoEvents();
    ICommandControlsEnumerator AllReferencedControls(IControlDefinition Definition);
    void ResetRibbonInterface();
    string GetCommandPaths(string CommandInternalName, object Environment);
    void RegisterFileExtension(INameValueMap pValueMap);
}
