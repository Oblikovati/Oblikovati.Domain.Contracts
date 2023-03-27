namespace Oblikovati.Domain.Contracts;

public interface ISketchCircles : IList<ISketchCircles>
{

    int Count { get; }
    ISketchCircle Item { get; }
    IEnumerator GetEnumerator();
    ISketchCircle AddByCenterRadius(object CenterPoint, double Radius);
    ISketchCircle AddByThreePoints(IPoint2d PointOne, IPoint2d PointTwo, IPoint2d PointThree);
}
