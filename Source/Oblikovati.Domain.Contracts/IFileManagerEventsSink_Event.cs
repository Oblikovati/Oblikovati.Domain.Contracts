using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IFileManagerEventsSink_Event
{
    void add_OnFileDelete(FileManagerEventsSink_OnFileDeleteEventHandler handler);
    void remove_OnFileDelete(FileManagerEventsSink_OnFileDeleteEventHandler handler);
    void add_OnFileCopy(FileManagerEventsSink_OnFileCopyEventHandler handler);
    void remove_OnFileCopy(FileManagerEventsSink_OnFileCopyEventHandler handler);
}
