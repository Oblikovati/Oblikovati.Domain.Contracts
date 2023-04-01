using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application;

public interface INotebookOptions
{
    bool DisplayNoteIcons { get; set; }
    bool DisplayNoteText { get; set; }
    bool KeepNotesOnDeletedObjects { get; set; }
    IColor TextBackgroundColor { get; set; }
    IColor ArrowColor { get; set; }
    IColor NoteHighlightColor { get; set; }
}