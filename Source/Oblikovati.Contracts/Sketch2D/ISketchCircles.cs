using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchCircles : IList<ISketchCircles>
{
    ISketchCircle Item { get; }

    ISketchCircle AddByCenterRadius(object CenterPoint, double Radius);
    ISketchCircle AddByThreePoints(IPoint2d PointOne, IPoint2d PointTwo, IPoint2d PointThree);
}