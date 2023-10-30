using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;

/// <summary>
/// The ControlDefinition object is the base class for all other command definition types. 
/// This includes the following objects: ButtonDefinition, ComboBoxDefinition, and MacroControlDefinition.
/// </summary>
public interface IControlDefinition
{
    /// <summary>
    /// Property that returns the internal name. This name is the internal unique identifier for the ControlDefinition.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the display name of the ControlDefinition.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that specifies if the control or definition is a standard Oblikovati control or definition. 
    /// Built-in ones have restrictions in the edits that can be performed.
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Property that returns the command classification of the ControlDefinition. 
    /// These classifications are bits and can be combined to designate that a command falls within more than one classification. 
    /// Because they are bits, care needs to be taken when interpreting the returned values.
    /// </summary>
    CommandTypesEnum Classification { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    ICommandManager Parent { get; }
    /// <summary>
    /// Property that returns the control definition type. The possible return values are kButtonDefinition, kComboBoxDefinition, and kMacroControlDefinition.
    /// </summary>
    ControlDefinitionTypeEnum DefinitionType { get; }
    /// <summary>
    /// Gets/Sets Description Text. For MacroControlDefinition this property is read-only.
    /// </summary>
    string DescriptionText { get; set; }
    /// <summary>
    /// Enables/Disables the UIDefinition object.
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Gets/Sets Tooltip. For MacroControlDefinition this property is read-only
    /// </summary>
    string ToolTipText { get; set; }
    IControlDefinitionEvents ControlDefinitionEvents { get; }
    /// <summary>
    /// Property that returns the string that uniquely identifies the client. 
    /// </summary>
    Guid? ClientId { get; }
    /// <summary>
    /// Gets/Sets the default (internal) shortcut assigned to the command.
    /// Setting this property fails for built-in ControlDefinitions.
    /// </summary>
    string DefaultShortcut { get; set; }
    /// <summary>
    /// Property that returns the type of shortcut assigned to this command.
    /// </summary>
    ShortcutTypeEnum DefaultShortcutType { get; }
    /// <summary>
    /// Property that returns whether the default (internal) shortcut has been overridden by the user or through the API.
    /// </summary>
    bool IsShortcutOverridden { get; }
    /// <summary>
    /// Gets/Sets the override shortcut assigned to the command. Setting this property to a null string clears the override.
    /// </summary>
    string OverrideShortcut { get; set; }
    /// <summary>
    /// Property that returns the type of override shortcut assigned to this command.
    /// </summary>
    ShortcutTypeEnum OverrideShortcutType { get; }
    /// <summary>
    /// Property that returns a ProgressiveToolTip object providing access to enhanced tooltip display for controls in the ribbon interface.
    /// </summary>
    IProgressiveToolTip ProgressiveToolTip { get; }
    /// <summary>
    /// Read-write property that gets and sets the introduced in version of the control definition.
    /// The values from AvailableComparisonVersions can be used to set this property. 
    /// This is read only if the control definition is built-in or if it is MacroControlDefinition.
    /// </summary>
    string IntroducedInVersion { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the last updated version of the control definition. 
    /// The values from AvailableComparisonVersions can be used to set this property. 
    /// This is read only if the control definition is built-in or if it is MacroControlDefinition.
    /// </summary>
    string LastUpdatedVersion { get; set; }
    /// <summary>
    /// Method that deletes the control definition. This method fails for built-in definitions.
    /// </summary>
    void Delete();
    /// <summary>
    /// Method that automatically adds a control based on this definition to the General panel of the Add-Ins tab in the ribbon interface.
    /// </summary>
    void AutoAddToGUI();
    /// <summary>
    /// Method that runs the built-in command or sends the Click event to the Add-In. 
    /// The end result of calling the Execute method is the same as if the user had clicked/pressed the relevant control - 
    /// for example, by clicking on a button that references a ButtonDefinition object.
    /// </summary>
    void Execute();
    /// <summary>
    /// Method that executes the control definition synchronously or asynchronously.
    /// </summary>
    /// <param name="Synchronous"></param>
    void Execute(bool Synchronous);
}