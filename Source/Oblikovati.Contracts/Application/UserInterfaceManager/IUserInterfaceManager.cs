using Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;
using Oblikovati.Contracts.Application.UserInterfaceManager.BalloonTips;
using Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;
using Oblikovati.Contracts.Application.UserInterfaceManager.DockableWindows;
using Oblikovati.Contracts.Application.UserInterfaceManager.Environments;
using Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.UserInterfaceManager;

public interface IUserInterfaceManager : IInjectableSingletonEntity
{
    ICommandBars CommandBars { get; }

    /// <summary>
    /// Property that returns the Environment that is currently active.
    /// </summary>
    IEnvironment ActiveEnvironment { get; set; }

    /// <summary>
    /// Property that returns the list of Environments valid for the edit target or the environment being switched to.
    /// Environments can be added to or removed from the list as seen appropriate by the client when an OnNewEditObject
    /// or an OnEnvironmentChange event is received. This list of environments will show in the Applications menu item.
    /// This list may only contain non-built-in environments.
    /// </summary>
    IEnvironmentList ParallelEnvironments { get; }

    /// <summary>
    ///  Property that returns the Environments collection object. 
    /// </summary>
    IEnvironments Environments { get; }

    /// <summary>
    /// Show/Hide Browser.
    /// </summary>
    bool ShowBrowser { get; set; }

    /// <summary>
    /// Gets/Sets the Boolean flag indicating whether the UI is in Expert mode.
    /// </summary>
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

    /// <summary>
    /// Allows Oblikovati to process all Windows messages currently in the message queue.
    /// </summary>
    void DoEvents();

    /// <summary>
    /// Method that returns all command controls in Oblikovati's ribbon interface that reference the input ControlDefinition.
    /// Controls from ribbons panels, Quick Access Toolbar and the File Browser (application menu) are returned.
    /// </summary>
    /// <param name="Definition"></param>
    /// <returns></returns>
    ICommandControlsEnumerator AllReferencedControls(IControlDefinition Definition);

    /// <summary>
    /// Method that removes all customizations from the ribbon user interface.
    /// </summary>
    void ResetRibbonInterface();

    /// <summary>
    /// Method that returns all the paths that the given command is found in, optionally filtered to an environment.
    /// </summary>
    /// <param name="CommandInternalName"></param>
    /// <param name="Environment"></param>
    /// <returns></returns>
    string GetCommandPaths(string CommandInternalName, object Environment);
}