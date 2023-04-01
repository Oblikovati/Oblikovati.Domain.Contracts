using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingBOM
{
    IDrawingBOMColumns DrawingBOMColumns { get; }
    IDrawingBOMRows DrawingBOMRows { get; }
    PartsListLevelEnum Level { get; }
    IDrawingDocument Parent { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
}