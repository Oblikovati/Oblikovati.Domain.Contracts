namespace Oblikovati.Domain.Contracts;

public interface I_DocPerformanceMonitorSink
{
    void OnSegmentLoad(string SegmentName);
    void OnDatabaseClose();
    void OnIStorageOpen(int OpenedWithFlags);
    void OnIStorageClose();
    void OnViewUpdate(object View, int BeforeOrAfter, INameValueMap Context);
    void OnIdle(INameValueMap Context);
}
