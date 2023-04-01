namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingHatchPattern
{
    IDrawingHatchPatternsManager Parent { get; }
    string Description { get; }
    bool Offered { get; set; }
    string Name { get; }
}