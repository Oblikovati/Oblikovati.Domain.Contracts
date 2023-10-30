using Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;

/// <summary>
/// The CommandControls collection object provides access to a collection of user interface controls
/// and provides methods to create additional controls.
/// </summary>
public interface ICommandControls : IDictionary<string, ICommandControl>
{

    /// <summary>
    /// 	Method that creates a new button CommandControl object.
    /// An example of this type of control is the 'Extrude' feature command button.
    /// </summary>
    /// <param name="ButtonDefinition"></param>
    /// <param name="UseLargeIcon"></param>
    /// <param name="ShowText"></param>
    /// <param name="TargetControlInternalName"></param>
    /// <param name="InsertBeforeTargetControl"></param>
    /// <returns></returns>
    ICommandControl AddButton(IButtonDefinition ButtonDefinition, bool UseLargeIcon, bool ShowText = false,
        string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);

    /// <summary>
    /// Method that creates a new popup CommandControl object.
    /// An example of this type of control is the 'Display Mode' drop down (Shaded, Hidden Edge, Wireframe)
    /// available on the 'View' tab of the ribbon in parts and assemblies.
    /// </summary>
    /// <param name="ButtonDefinitions"></param>
    /// <param name="UseLargeIcon"></param>
    /// <param name="ShowText"></param>
    /// <param name="TargetControlInternalName"></param>
    /// <param name="InsertBeforeTargetControl"></param>
    /// <returns></returns>
    ICommandControl AddButtonPopup(IObjectCollection ButtonDefinitions, bool UseLargeIcon, bool ShowText,
        string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);

    /// <summary>
    /// Method that creates a new combo-box CommandControl object.
    /// </summary>
    /// <param name="ComboBoxDefinition"></param>
    /// <param name="TargetControlInternalName"></param>
    /// <param name="InsertBeforeTargetControl"></param>
    /// <returns></returns>
    ICommandControl AddComboBox(IComboBoxDefinition ComboBoxDefinition, string TargetControlInternalName = "",
        bool InsertBeforeTargetControl = false);

    /// <summary>
    /// Method that creates a new macro CommandControl object.
    /// </summary>
    /// <param name="MacroControlDefinition"></param>
    /// <param name="UseLargeIcon"></param>
    /// <param name="ShowText"></param>
    /// <param name="TargetControlInternalName"></param>
    /// <param name="InsertBeforeTargetControl"></param>
    /// <returns></returns>
    ICommandControl AddMacro(IMacroControlDefinition MacroControlDefinition, bool UseLargeIcon, bool ShowText,
        string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);

    /// <summary>
    /// Method that creates a new popup CommandControl object.
    /// An example of this type of control is the 'Switch' control available in the Windows panel of the View tab.
    /// </summary>
    /// <param name="DisplayedControl"></param>
    /// <param name="ButtonDefinitions"></param>
    /// <param name="UseLargeIcon"></param>
    /// <param name="ShowText"></param>
    /// <param name="TargetControlInternalName"></param>
    /// <param name="InsertBeforeTargetControl"></param>
    /// <returns></returns>
    ICommandControl AddPopup(IButtonDefinition DisplayedControl, IObjectCollection ButtonDefinitions, bool UseLargeIcon,
        bool ShowText, string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);

    /// <summary>
    /// Method that creates a new separator CommandControl object.
    /// </summary>
    /// <param name="TargetControlInternalName"></param>
    /// <param name="InsertBeforeTargetControl"></param>
    /// <returns></returns>
    ICommandControl AddSeparator(string TargetControlInternalName, bool InsertBeforeTargetControl = false);

    /// <summary>
    /// Method that creates a new split button CommandControl object.
    /// An example of this type of control is the 'New File' split button drop down available in the Quick Access Toolbar.
    /// </summary>
    /// <param name="DisplayedControl"></param>
    /// <param name="ButtonDefinitions"></param>
    /// <param name="UseLargeIcon"></param>
    /// <param name="ShowText"></param>
    /// <param name="TargetControlInternalName"></param>
    /// <param name="InsertBeforeTargetControl"></param>
    /// <returns></returns>
    ICommandControl AddSplitButton(IButtonDefinition DisplayedControl, IObjectCollection ButtonDefinitions,
        bool UseLargeIcon, bool ShowText, string TargetControlInternalName = "",
        bool InsertBeforeTargetControl = false);

    ICommandControl AddSplitButtonMRU(IObjectCollection ButtonDefinitions, bool UseLargeIcon, bool ShowText,
        string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);

    ICommandControl AddGallery(IObjectCollection ButtonDefinitions, bool DisplayAsComboBox, int Width,
        string TargetControlInternalName = "", bool InsertBeforeTargetControl = false);

    ICommandControl AddTogglePopup(IButtonDefinition DisplayedControl, IObjectCollection ButtonDefinitions,
        bool UseLargeIcon, bool ShowText, string TargetControlInternalName = "",
        bool InsertBeforeTargetControl = false);

    ICommandControl AddCopy(ICommandControl CommandControl, string TargetControlInternalName = "",
        bool InsertBeforeTargetControl = false);
}