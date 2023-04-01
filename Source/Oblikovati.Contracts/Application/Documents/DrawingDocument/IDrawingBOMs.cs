namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingBOMs : IList<IDrawingBOMs>
{
    IDrawingBOM Item { get; }
    bool IsDrawingBOMDefined(string FullFileName);
}