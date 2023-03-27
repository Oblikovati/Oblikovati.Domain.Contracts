using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IIRxFileAccessEvents_Event
{
    void add_OnFileResolution(IRxFileAccessEvents_OnFileResolutionEventHandler handler);
    void remove_OnFileResolution(IRxFileAccessEvents_OnFileResolutionEventHandler handler);
    void add_OnFileDirty(IRxFileAccessEvents_OnFileDirtyEventHandler handler);
    void remove_OnFileDirty(IRxFileAccessEvents_OnFileDirtyEventHandler handler);
}
