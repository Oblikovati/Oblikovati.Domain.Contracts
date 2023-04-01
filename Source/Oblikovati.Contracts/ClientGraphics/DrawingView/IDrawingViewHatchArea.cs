using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.ClientGraphics.DrawingView;

public interface IDrawingViewHatchArea
{
    IDrawingViewHatchRegion Parent { get; }
    IObjectCollection BoundaryGeometries { get; }
    IBox2d RangeBox { get; }
}