using Oblikovati.Contracts.Application.Documents.DrawingDocument;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;

public interface ISheetSettings
{
    IDrawingDocument Parent { get; }
    string DraftViewLabel { get; set; }
    string SheetLabel { get; set; }
    string ViewLabel { get; set; }
    IColor SheetEntityHighlightColor { get; set; }
    IColor SheetEntitySelectionColor { get; set; }
    IColor SheetColor { get; set; }
    IColor SheetOutlineColor { get; set; }
}