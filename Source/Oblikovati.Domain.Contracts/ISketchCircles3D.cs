namespace Oblikovati.Domain.Contracts;

public interface ISketchCircles3D : IList<ISketchCircles3D>
{

    int Count { get; }
    ISketchCircle3D Item { get; }
    IEnumerator GetEnumerator();
    ISketchCircle3D AddByCenterRadius(object CenterPoint, IUnitVector Normal, double Radius);
    ISketchCircle3D AddByThreePoints(object StartPoint, object MidPoint, object EndPoint);
}
