using Oblikovati.Contracts.Application.Documents.AssemblyDocument.BOM;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingBOMRow : IList<IDrawingBOMRow>
{
    IBOMRow BOMRow { get; }

    bool Ballooned { get; }
    bool Custom { get; }
    bool Virtual { get; }
    IDrawingBOMCell Item { get; }
    IDrawingBOM Parent { get; }
}