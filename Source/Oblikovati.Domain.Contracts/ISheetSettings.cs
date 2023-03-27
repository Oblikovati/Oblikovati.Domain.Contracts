namespace Oblikovati.Domain.Contracts;

public interface ISheetSettings
{

    I_DrawingDocument Parent { get; }
    string DraftViewLabel { get; set; }
    string SheetLabel { get; set; }
    string ViewLabel { get; set; }
    IColor SheetEntityHighlightColor { get; set; }
    IColor SheetEntitySelectionColor { get; set; }
    IColor SheetColor { get; set; }
    IColor SheetOutlineColor { get; set; }
}
