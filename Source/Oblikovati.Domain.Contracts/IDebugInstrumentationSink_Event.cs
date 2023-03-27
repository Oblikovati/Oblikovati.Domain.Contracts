using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IDebugInstrumentationSink_Event
{
    void add_ObjectCreated(DebugInstrumentationSink_ObjectCreatedEventHandler handler);
    void remove_ObjectCreated(DebugInstrumentationSink_ObjectCreatedEventHandler handler);
    void add_ObjectDestroyed(DebugInstrumentationSink_ObjectDestroyedEventHandler handler);
    void remove_ObjectDestroyed(DebugInstrumentationSink_ObjectDestroyedEventHandler handler);
    void add_ObjectAddRefd(DebugInstrumentationSink_ObjectAddRefdEventHandler handler);
    void remove_ObjectAddRefd(DebugInstrumentationSink_ObjectAddRefdEventHandler handler);
    void add_ObjectReleased(DebugInstrumentationSink_ObjectReleasedEventHandler handler);
    void remove_ObjectReleased(DebugInstrumentationSink_ObjectReleasedEventHandler handler);
    void add_ObjectQueryInterfaced(DebugInstrumentationSink_ObjectQueryInterfacedEventHandler handler);
    void remove_ObjectQueryInterfaced(DebugInstrumentationSink_ObjectQueryInterfacedEventHandler handler);
    void add_OnMemberInvoke(DebugInstrumentationSink_OnMemberInvokeEventHandler handler);
    void remove_OnMemberInvoke(DebugInstrumentationSink_OnMemberInvokeEventHandler handler);
}
