namespace Oblikovati.Domain.Contracts;

public interface ISketchFixedSplines3D : IList<ISketchFixedSplines3D>
{
    ISketchFixedSpline3D Item { get; }

    int Count { get; }
    IEnumerator GetEnumerator();
    ISketchFixedSpline3D Add(IBSplineCurve SplineCurve, object StartPoint, object EndPoint);
    ISketchFixedSpline3D AddByEdge(IEdge TransientEdge);
}
