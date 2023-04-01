namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingBOMRows : IList<IDrawingBOMRows>
{
    IDrawingBOMRow Item { get; }
}