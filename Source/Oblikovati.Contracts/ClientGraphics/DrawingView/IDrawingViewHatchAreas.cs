namespace Oblikovati.Contracts.ClientGraphics.DrawingView;

public interface IDrawingViewHatchAreas : IList<IDrawingViewHatchAreas>
{
    IDrawingViewHatchArea Item { get; }
}