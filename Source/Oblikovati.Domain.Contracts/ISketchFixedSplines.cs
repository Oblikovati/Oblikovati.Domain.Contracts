namespace Oblikovati.Domain.Contracts;

public interface ISketchFixedSplines : IList<ISketchFixedSplines>
{
    ISketchFixedSpline Item { get; }

    int Count { get; }
    IEnumerator GetEnumerator();
    ISketchFixedSpline Add(IBSplineCurve2d SplineCurve, object StartPoint, object EndPoint);
}
