using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IChangeProcessorSink_Event
{
    void add_OnExecute(ChangeProcessorSink_OnExecuteEventHandler handler);
    void remove_OnExecute(ChangeProcessorSink_OnExecuteEventHandler handler);
    void add_OnReadFromScript(ChangeProcessorSink_OnReadFromScriptEventHandler handler);
    void remove_OnReadFromScript(ChangeProcessorSink_OnReadFromScriptEventHandler handler);
    void add_OnWriteToScript(ChangeProcessorSink_OnWriteToScriptEventHandler handler);
    void remove_OnWriteToScript(ChangeProcessorSink_OnWriteToScriptEventHandler handler);
    void add_OnTerminate(ChangeProcessorSink_OnTerminateEventHandler handler);
    void remove_OnTerminate(ChangeProcessorSink_OnTerminateEventHandler handler);
}
