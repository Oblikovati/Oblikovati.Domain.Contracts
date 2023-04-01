namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingBOMCell
{
    IDrawingBOM Parent { get; }
    bool Static { get; }
    string Value { get; }
}