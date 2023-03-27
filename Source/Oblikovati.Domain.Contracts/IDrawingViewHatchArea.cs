namespace Oblikovati.Domain.Contracts;

public interface IDrawingViewHatchArea
{

    IDrawingViewHatchRegion Parent { get; }
    IObjectCollection BoundaryGeometries { get; }
    IBox2d RangeBox { get; }
}
