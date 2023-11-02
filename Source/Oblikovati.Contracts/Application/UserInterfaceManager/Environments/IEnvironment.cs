using Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;
using Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.Environments;

/// <summary>
/// The Environment object represents any Oblikovati environment.
/// Example environments are Part, Assembly, Sketch, etc.
/// The Environment represents the current state of an environment.
/// </summary>
public interface IEnvironment : IEnvironmentBase
{
    /// <summary>
    /// Property that returns the string that uniquely identifies the client.
    /// This is the UUID of the AddIn
    /// </summary>
    Guid ClientId { get; }
    ICommandBar DefaultMenuBar { get; set; }
    /// <summary>
    /// Property that specifies if the Environment a standard Oblikovati Environment or if it has been added by a client.
    /// Built-in environments have restrictions in the edits that can be performed.
    /// For example, build-in environments cannot be deleted. For more information, see the Environments overview.
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Property that returns the DisabledCommandList object.
    /// This object allows the environment to disable commands when this environment is active.
    /// This list contains commands that are disabled in addition to those specified by the DisabledCommandTypes property.
    /// </summary>
    IDisabledCommandList DisabledCommandList { get; }
    /// <summary>
    /// Gets list of disabled command types for the Environment.
    /// </summary>
    CommandTypesEnum DisabledCommandTypes { get; set; }
    ICommandBarList ContextMenuList { get; }
    IPanelBar PanelBar { get; }
    /// <summary>
    /// Gets and sets an array of strings containing the internal names of ribbon tabs that should
    /// be displayed in this environment.
    /// These are in addition to the tabs displayed as a result of setting the InheritAllRibbonTabs property to True.
    /// </summary>
    List<string> AdditionalVisibleRibbonTabs { get; set; }
    /// <summary>
    /// Gets and sets the internal name of the ribbon tab that should be displayed when this environment is activated.
    /// </summary>
    string DefaultRibbonTab { get; set; }
    /// <summary>
    /// Gets and sets whether this environment should inherit all ribbon tabs from the 'base' environment.
    /// This property applies only to custom environments.
    /// If set to True, all visible tabs in the base environment are displayed in this environment.
    /// </summary>
    bool InheritAllRibbonTabs { get; set; }
    /// <summary>
    /// Property that returns the Ribbon object associated with this environment.
    /// This property returns Nothing when the environment is initially created
    /// and not yet applied as an override or a parallel environment.
    /// </summary>
    IRibbon Ribbon { get; }
    /// <summary>
    /// Returns the RadialMarkingMenus object that can be used to query and set the selection based radial menu.
    /// </summary>
    IRadialMarkingMenus RadialMarkingMenus { get; }
    object EnabledCommandList { get; set; }
    /// <summary>
    /// Gets and sets the exit display name of the environment, to be used on the Finish button.
    /// As default this will be the same as the DisplayName.
    /// This is the name displayed to the user and should be localized for the current locale.
    /// </summary>
    string ExitDisplayName { get; set; }
    /// <summary>
    /// Gets and sets whether the environment status would be preserved when switch model state in an assembly.
    /// This would make sure the environment to be preserved when switch between substitute model state
    /// and other model state in an assembly.For built-in environments.
    /// </summary>
    bool PreserveWhenSwitchModelState { get; set; }
    /// <summary>
    /// Method that deletes the environment. This method will fail for built-in environments.
    /// </summary>
    void Delete();
    /// <summary>
    /// Returns the RadialMarkingMenu object that can be used to query and set the commands available
    /// in the radial menu for the input object type.
    /// </summary>
    /// <param name="ObjectType"></param>
    /// <returns></returns>
    IRadialMarkingMenu GetRadialMarkingMenu(object ObjectType);
}