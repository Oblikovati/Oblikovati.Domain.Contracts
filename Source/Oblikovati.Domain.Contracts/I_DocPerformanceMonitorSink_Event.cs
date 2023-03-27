using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface I_DocPerformanceMonitorSink_Event
{
    void add_OnSegmentLoad(_DocPerformanceMonitorSink_OnSegmentLoadEventHandler handler);
    void remove_OnSegmentLoad(_DocPerformanceMonitorSink_OnSegmentLoadEventHandler handler);
    void add_OnDatabaseClose(_DocPerformanceMonitorSink_OnDatabaseCloseEventHandler handler);
    void remove_OnDatabaseClose(_DocPerformanceMonitorSink_OnDatabaseCloseEventHandler handler);
    void add_OnIStorageOpen(_DocPerformanceMonitorSink_OnIStorageOpenEventHandler handler);
    void remove_OnIStorageOpen(_DocPerformanceMonitorSink_OnIStorageOpenEventHandler handler);
    void add_OnIStorageClose(_DocPerformanceMonitorSink_OnIStorageCloseEventHandler handler);
    void remove_OnIStorageClose(_DocPerformanceMonitorSink_OnIStorageCloseEventHandler handler);
    void add_OnViewUpdate(_DocPerformanceMonitorSink_OnViewUpdateEventHandler handler);
    void remove_OnViewUpdate(_DocPerformanceMonitorSink_OnViewUpdateEventHandler handler);
    void add_OnIdle(_DocPerformanceMonitorSink_OnIdleEventHandler handler);
    void remove_OnIdle(_DocPerformanceMonitorSink_OnIdleEventHandler handler);
}
