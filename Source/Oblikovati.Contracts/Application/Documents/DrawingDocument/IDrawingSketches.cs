namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingSketches : IList<IDrawingSketches>
{
    IDrawingSketch Item { get; }


    IDrawingSketch Add();
}