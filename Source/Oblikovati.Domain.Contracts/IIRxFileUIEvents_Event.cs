using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IIRxFileUIEvents_Event
{
    void add_OnFileNewDialog(IRxFileUIEvents_OnFileNewDialogEventHandler handler);
    void remove_OnFileNewDialog(IRxFileUIEvents_OnFileNewDialogEventHandler handler);
    void add_OnFileOpenDialog(IRxFileUIEvents_OnFileOpenDialogEventHandler handler);
    void remove_OnFileOpenDialog(IRxFileUIEvents_OnFileOpenDialogEventHandler handler);
    void add_OnFileSaveAsDialog(IRxFileUIEvents_OnFileSaveAsDialogEventHandler handler);
    void remove_OnFileSaveAsDialog(IRxFileUIEvents_OnFileSaveAsDialogEventHandler handler);
    void add_OnFileInsertNewDialog(IRxFileUIEvents_OnFileInsertNewDialogEventHandler handler);
    void remove_OnFileInsertNewDialog(IRxFileUIEvents_OnFileInsertNewDialogEventHandler handler);
    void add_OnFileInsertDialog(IRxFileUIEvents_OnFileInsertDialogEventHandler handler);
    void remove_OnFileInsertDialog(IRxFileUIEvents_OnFileInsertDialogEventHandler handler);
}
