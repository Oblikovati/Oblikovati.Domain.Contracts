namespace Oblikovati.Domain.Contracts;

public interface I_AppPerformanceMonitor
{
    int AllMemoryInUse { get; }
    int ASMActiveEntityMemory { get; }
    int ASMHistoryMemory { get; }
    bool StatsActive { get; set; }
    void GetMemoryInUse(out int Committed, out int Reserved);
    void SetGraphicsLOD(ref List<double> LODTolerances);
    void GetASMMemoryTotals(out long Allocations, out long DeAllocations, out int BytesAllocated, out int HighWaterMark);
    void GetASMFreeListMemory(out int Blocks, out int EmptyBlocks, out int TotalBytes, out int AllocatedBytes);
    void GetASMMemoryUtilizationRatios(out double Gross, out double Capacity, out double Theoretical);
    void InitStats();
    void StartTimer(string TimerName);
    void LogElapsedTime(string TimerName);
    void LogMemoryStatistics(string MemStatName);
    string OutputMetrics();
    void OutputElapsedTime(string TimerName, out int ElapsedTime);
    void OutputMemoryStatistics(string EntryName, out string CommittedMem, out string ReservedMem, out string WastedMem);
}
