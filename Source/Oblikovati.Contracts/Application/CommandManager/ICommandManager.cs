using Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;
using Oblikovati.Contracts.Application.CommandManager.InteractionEvents;
using Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MiniToolbar;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager;

/// <summary>
/// The CommandManager object provides functionality that interacts with the various user interaction events.
/// </summary>
public interface ICommandManager : IInjectableSingletonEntity
{
    /// <summary>
    /// Clears the contents of Autodesk Inventor's internal clipboard.
    /// </summary>
    public void ClearPrivateEvents();
    /// <summary>
    /// Method that creates a new DragContext object.
    /// </summary>
    /// <returns></returns>
    public IDragContext CreateDragContext();
    /// <summary>
    /// Method that creates and returns a new InteractionEvents object.
    /// The InteractionEvents object is created for document that is currently active.
    /// </summary>
    /// <returns></returns>
    public IInteractionEvents CreateInteractionEvents();
    /// <summary>
    /// Method that creates a MiniToolbar object.
    /// </summary>
    /// <returns></returns>
    public IMiniToolbar CreateMiniToolbar();
    /// <summary>
    /// Method that causes Oblikovati to go through the pre-selection protocol, including firing of corresponding
    /// event out the active InteractionEvents object if one is active.
    /// If a native Oblikovati command is active and is in a selection mode, it gets the pre-select notification just
    /// like a native pre-selection happened. This method is useful when you want to perform picking outside of the
    /// graphic window. For example if you have a browser that has icons that represent selectable objects you can
    /// cause the selection behavior to happen as the user navigates through your browser and selects objects.
    /// </summary>
    /// <param name="Entity"></param>
    public void DoPreSelect(object Entity);
    /// <summary>
    /// Method that causes Oblikovati to go through the selection protocol, including firing of corresponding event out
    /// the active InteractionEvents object if one is active. If a native Oblikovati command is active and is in
    /// a selection mode, it gets the select notification just like a native selection happened.
    /// This method is useful when you want to perform picking outside of the graphic window.
    /// For example if you have a browser that has icons that represent selectable objects you can cause the selection
    /// behavior to happen as the user navigates through your browser and selects objects.
    /// </summary>
    /// <param name="Entity"></param>
    public void DoSelect(object Entity);
    /// <summary>
    /// Method that causes Oblikovati to go through the stop pre-selection protocol, including firing of corresponding
    /// event out the active InteractionEvents object if one is active. If a native Oblikovati command is active and is
    /// in a selection mode, it gets the stop pre-select notification just like a native stop pre-selection happened.
    /// This method is useful when you want to perform picking outside of the graphic window.
    /// For example if you have a browser that has icons that represent selectable objects you can cause the selection
    /// behavior to happen as the user navigates through your browser and selects objects.
    /// </summary>
    /// <param name="Entity">Input Oblikovati object, including custom graphics object, that needs to be understood as
    /// a candidate for selection by the active selection process in progress. This entity may have been picked by
    /// a means not known to native Oblikovati (say a foreign browser).</param>
    public void DoStopPreSelect(object Entity);
    /// <summary>
    /// Method that causes Oblikovati to go through the de-selection protocol, including firing of corresponding event
    /// out the active InteractionEvents object if one is active. If a native Oblikovati command is active and is in
    /// a selection mode, it gets the de-select notification just like a native de-selection happened.
    /// This method is useful when you want to perform picking outside of the graphic window.
    /// For example if you have a browser that has icons that represent selectable objects you can cause the selection
    /// behavior to happen as the user navigates through your browser and selects objects.
    /// </summary>
    /// <param name="Entity">Input Oblikovati object, including custom graphics object, that needs to be understood
    /// as being de-selected by the active selection process in progress. This entity may have been picked by a means
    /// not known to native Oblikovati (say a foreign browser).</param>
    public void DoUnSelect(object Entity);
    /// <summary>
    /// Method that queries data contained by Autodesk Inventor's internal clipboard.
    /// </summary>
    /// <param name="DataType">Indicates the type of value contained by the clipboard.</param>
    /// <param name="Data">The actual data contained by the clipboard.</param>
    public void PeekPrivateEvent(out PrivateEventTypeEnum DataType, out object Data);
    /// <summary>
    /// Method that allows the user to pick a single entity.
    /// </summary>
    /// <param name="Filter">SelectionFilterEnum Entity filter</param>
    /// <param name="PromptText">Text to display as prompt.</param>
    /// <returns></returns>
    public object Pick(SelectionFilterEnum Filter, string PromptText);
    /// <summary>
    /// Method that posts data onto Oblikovati's internal clipboard. Certain commands that usually obtain information
    /// using a dialog, i.e. Open, Save, etc., look first to see if data is on the clipboard before displaying the dialog.
    /// If valid information is on the clipboard the command will use it instead of displaying the dialog and asking
    /// the user to specify the filename.
    /// </summary>
    /// <param name="Tag"></param>
    /// <param name="Data">Input Variant that contains the actual data to push onto Oblikovati's clipboard.
    /// When set the DateType as kBooleanEvent, then a NameValueMap object including the data name and value should be
    /// provided.</param>
    public void PostPrivateEvent(string Tag, object Data);
    /// <summary>
    /// Method that posts data onto Oblikovati's internal clipboard. Certain commands that usually obtain information
    /// using a dialog, i.e. Open, Save, etc., look first to see if data is on the clipboard before displaying the dialog.
    /// If valid information is on the clipboard the command will use it instead of displaying the dialog and asking
    /// the user to specify the filename.
    /// </summary>
    /// <param name="DataType">Input constant that specifies the type of value being pushed onto Oblikovati's clipboard.
    /// Most often this will be kFileNameEvent.</param>
    /// <param name="Data">Input Variant that contains the actual data to push onto Oblikovati's clipboard.
    /// When set the DateType as kBooleanEvent, then a NameValueMap object including the data name and value should be
    /// provided.</param>
    public void PostPrivateEvent(PrivateEventTypeEnum DataType, object Data);
    /// <summary>
    /// This method allows the developer to put up prompt messages (unless the user has suppressed this prompt) much
    /// like the Visual Basic MsgBox functionality.
    /// Remarks :
    /// If you pick one of the radio buttons in the "Prompts" section of the dialog, the prompt and your choice will be
    /// saved to the registry, and your selection will work for future uses of the prompt (i.e. when the client calls the
    /// prompt, if the user has selected one of the "don't ask me" options, the dialog is suppressed, and the answer
    /// specified earlier by the user is returned).
    /// </summary>
    /// <param name="Prompt">The string that will appear in the dialog. The string can include "%s" to indicate a string
    /// placeholder, while you can specify the string value using the PromptStrings argument.
    /// The string can also specify the hyperlink with XML tags.</param>
    /// <param name="Buttons">Describes which buttons will be used, and which is the default answer.
    /// For example "vbOKCancel + vbDefaultButton1", or "vbYesNo".</param>
    /// <param name="Title">Each time you call the function, you can give it a new dialog title/caption.
    /// If not supplied, the title will default to "Oblikovati x", where x is the release number.</param>
    /// <returns></returns>
    public int PromptMessage(string Prompt, int Buttons, string? Title = null
        /*, DefaultAnswer, object Restrictions, object PromptStrings*/);
    /// <summary>
    /// Method that causes the specified executable to be run.
    /// Using the Parameters argument you can also pass arguments to the executable.
    /// </summary>
    /// <param name="ExecutableName">Input String that contains the full path of the executable.</param>
    /// <param name="Parameters">Input string that contains the parameters. An empty string is valid in the case
    /// where the executable doesn't have any input arguments.</param>
    public void StartExecutable(string ExecutableName, string? Parameters = null);
    /// <summary>
    /// Method that causes the currently running command to be terminated.
    /// </summary>
    public void StopActiveCommand();
    /// <summary>
    /// Gets the active command (one that is currently running).
    /// </summary>
    public string ActiveCommand { get; }
    /// <summary>
    /// Property that returns the collection.
    /// </summary>
    public ICommandCategories CommandCategories { get; }
    /// <summary>
    /// Property that returns the ControlDefinitions collection.
    /// </summary>
    public IControlDefinitions ControlDefinitions { get; }
    /// <summary>
    /// Property that informs the client if Oblikovati is currently in selection mode or not. T
    /// his may be used, for example, by clients to test if calling the DoSelect (and related) methods
    /// will have any effect or not.
    /// </summary>
    public bool SelectionActive { get; }
    /// <summary>
    /// Property that returns the object that fires events on all user input (commands, keyboard, mouse, etc.).
    /// </summary>
    public IUserInputEvents UserInputEvents { get; }
    
    public bool CommandEnabled { get; }
    public CommandType ActiveCommandType { get; }
    public void StartCommand(CommandType BuiltInCommandId);
    public void StopAllActiveCommands();
}