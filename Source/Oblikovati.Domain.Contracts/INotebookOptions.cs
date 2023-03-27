namespace Oblikovati.Domain.Contracts;

public interface INotebookOptions
{

    bool DisplayNoteIcons { get; set; }
    bool DisplayNoteText { get; set; }
    bool KeepNotesOnDeletedObjects { get; set; }
    IColor TextBackgroundColor { get; set; }
    IColor ArrowColor { get; set; }
    IColor NoteHighlightColor { get; set; }
}
