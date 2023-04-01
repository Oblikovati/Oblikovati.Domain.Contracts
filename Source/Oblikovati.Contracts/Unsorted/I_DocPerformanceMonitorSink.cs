using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Unsorted;

public interface I_DocPerformanceMonitorSink
{
    void OnSegmentLoad(string SegmentName);
    void OnDatabaseClose();
    void OnIStorageOpen(int OpenedWithFlags);
    void OnIStorageClose();
    void OnViewUpdate(object View, int BeforeOrAfter, INameValueMap Context);
    void OnIdle(INameValueMap Context);
}