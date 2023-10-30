using Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;

/// <summary>
/// A CommandControl object represents a user interface control (button, combobox, split button, etc.).
/// </summary>
public interface ICommandControl
{
    /// <summary>
    /// Property that returns the display name of the control.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that returns the unique internal name of the control.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns a CommandControls collection object that provides access to the child controls of this control.
    /// </summary>
    ICommandControls ChildControls { get; }
    /// <summary>
    /// Property that returns the ControlDefinition associated with this control.
    /// </summary>
    IControlDefinition ControlDefinition { get; }
    /// <summary>
    /// Property that returns the control type.
    /// </summary>
    ControlTypeEnum ControlType { get; }
    /// <summary>
    /// Gets and sets the current ControlDefinition object for ButtonPopupControl, PopupControl, SplitButtonMRUControl and SplitButtonControl control types. 
    /// For other control types, this property returns Nothing.
    /// </summary>
    IControlDefinition DisplayedControl { get; set; }
    /// <summary>
    /// Gets and sets whether to display the text (display name) associated with the control. 
    /// The 'Ribbon Appearance' user choice overrides this setting.
    /// </summary>
    bool ShowText { get; set; }
    /// <summary>
    /// Gets and sets whether to display the control in the larger size. The 'Ribbon Appearance' user choice overrides this setting.
    /// </summary>
    bool UseLargeIcon { get; }
    /// <summary>
    /// Gets and sets whether this control is currently visible in the ribbon.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets and sets the keyboard access key for the control.
    /// </summary>
    string KeyTip { get; set; }
    /// <summary>
    /// Method that deletes the CommandControl. This simply removes the control from the panel, but does not delete the underlying ControlDefinition(s).
    /// </summary>
    void Delete();
}