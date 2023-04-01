namespace Oblikovati.Contracts.ClientGraphics.DrawingView;

public interface IDrawingViewHatchRegions : IList<IDrawingViewHatchRegions>
{
    IDrawingViewHatchRegion Item { get; }
}