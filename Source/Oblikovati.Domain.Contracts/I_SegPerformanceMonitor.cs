using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface I_SegPerformanceMonitor
{
    string Name { get; }
    _SegmentLoadState State { get; }
    void GetMemoryInUse(out int Committed, out int Reserved, out int RSeManagement);
    void GetMemoryInUseFor64Bit(out long Committed, out long Reserved, out long RSeManagement);
}
