using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingBOM
{

    IDrawingBOMColumns DrawingBOMColumns { get; }
    IDrawingBOMRows DrawingBOMRows { get; }
    PartsListLevelEnum Level { get; }
    I_DrawingDocument Parent { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
}
