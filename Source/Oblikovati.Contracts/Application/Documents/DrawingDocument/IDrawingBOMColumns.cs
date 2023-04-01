namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingBOMColumns : IList<IDrawingBOMColumns>
{
    IDrawingBOMColumn Item { get; }
}