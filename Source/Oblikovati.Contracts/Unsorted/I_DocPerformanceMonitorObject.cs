namespace Oblikovati.Contracts.Unsorted;

public interface I_DocPerformanceMonitorObject
{
    int SegmentCount { get; }
    I_SegPerformanceMonitor SegmentItem { get; }
    int NodeCount { get; }
    int ASMHistoryMemory { get; }
    bool LeakDetected { get; }
    void GetGraphicsLOD(out int NumberOfLODs, ref List<double> LODTolerances);
    void SetGraphicsLOD(int NumberOfLODs);
    void GetMemoryInUse(out int Committed, out int Reserved, out int InActiveUse);
    void SetDetectLeaks(bool detect);
    void DontSaveIdentifiedMTLeaks(bool dontSave);
}