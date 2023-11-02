using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IDebugInstrumentationObject
{
    string ObjectDescription { get; }
    object Object { get; }
    int ObjectReferenceCount { get; }
    int ObjectInstanceNumber { get; }
    DebugWatchType ObjectWatchType { get; set; }
    void GetLiveObjects(ref List<int> Cookies);
    int GetObjectCookie(object Object);
    void SetTrace(bool Enable, string TraceFilename);
    void GetTraceInfo(out bool Enabled, out string TraceFilename);
    void SetProfileInfo(bool Enable, bool WriteToFileOnStop, string FileName);
}