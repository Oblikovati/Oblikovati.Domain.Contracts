using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICommandManager : IInjectableSingletonEntity
{

    bool CommandEnabled { get; }
    CommandIDEnum _ActiveCommand { get; }
    string ActiveCommand { get; }
    bool SelectionActive { get; }
    IUserInputEvents UserInputEvents { get; }
    ICommandCategories CommandCategories { get; }
    IControlDefinitions ControlDefinitions { get; }
    void StartCommand(CommandIDEnum BuiltInCommandId);
    void StopActiveCommand();
    void StopAllActiveCommands();
    void StartExecutable(string ExecutableName, string Parameters);
    void PeekPrivateEvent(out PrivateEventTypeEnum DataType, out object Data);
    void PostPrivateEvent(PrivateEventTypeEnum DataType, object Data);
    void ClearPrivateEvents();
    void _PostPrivateEvent(string Tag, object Data);
    IInteractionEvents CreateInteractionEvents();
    void DoPreSelect(object Entity);
    void DoStopPreSelect(object Entity);
    void DoSelect(object Entity);
    void DoUnSelect(object Entity);
    int PromptMessage(string Prompt, int Buttons, object Title, object DefaultAnswer, object Restrictions, object PromptStrings);
    object Pick(SelectionFilterEnum Filter, string PromptText);
    IDragContext CreateDragContext();
    IMiniToolbar CreateMiniToolbar();
    int _PromptMessage(int MessageID);
}
