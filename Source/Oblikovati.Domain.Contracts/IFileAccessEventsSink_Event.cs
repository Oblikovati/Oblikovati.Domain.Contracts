using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IFileAccessEventsSink_Event
{
    void add_OnFileResolution(FileAccessEventsSink_OnFileResolutionEventHandler handler);
    void remove_OnFileResolution(FileAccessEventsSink_OnFileResolutionEventHandler handler);
    void add_OnFileDirty(FileAccessEventsSink_OnFileDirtyEventHandler handler);
    void remove_OnFileDirty(FileAccessEventsSink_OnFileDirtyEventHandler handler);
}
