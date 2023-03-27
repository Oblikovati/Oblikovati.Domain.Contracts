using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IFileUIEventsSink_Event
{
    void add_OnFileNewDialog(FileUIEventsSink_OnFileNewDialogEventHandler handler);
    void remove_OnFileNewDialog(FileUIEventsSink_OnFileNewDialogEventHandler handler);
    void add_OnFileOpenDialog(FileUIEventsSink_OnFileOpenDialogEventHandler handler);
    void remove_OnFileOpenDialog(FileUIEventsSink_OnFileOpenDialogEventHandler handler);
    void add_OnFileSaveAsDialog(FileUIEventsSink_OnFileSaveAsDialogEventHandler handler);
    void remove_OnFileSaveAsDialog(FileUIEventsSink_OnFileSaveAsDialogEventHandler handler);
    void add_OnFileInsertNewDialog(FileUIEventsSink_OnFileInsertNewDialogEventHandler handler);
    void remove_OnFileInsertNewDialog(FileUIEventsSink_OnFileInsertNewDialogEventHandler handler);
    void add_OnFileInsertDialog(FileUIEventsSink_OnFileInsertDialogEventHandler handler);
    void remove_OnFileInsertDialog(FileUIEventsSink_OnFileInsertDialogEventHandler handler);
    void add_OnFileOpenFromMRU(FileUIEventsSink_OnFileOpenFromMRUEventHandler handler);
    void remove_OnFileOpenFromMRU(FileUIEventsSink_OnFileOpenFromMRUEventHandler handler);
    void add_OnFileNew(FileUIEventsSink_OnFileNewEventHandler handler);
    void remove_OnFileNew(FileUIEventsSink_OnFileNewEventHandler handler);
    void add_OnPopulateFileMetadata(FileUIEventsSink_OnPopulateFileMetadataEventHandler handler);
    void remove_OnPopulateFileMetadata(FileUIEventsSink_OnPopulateFileMetadataEventHandler handler);
}
