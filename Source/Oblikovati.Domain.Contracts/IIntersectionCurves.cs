namespace Oblikovati.Domain.Contracts;

public interface IIntersectionCurves : IList<IIntersectionCurves>
{

    int Count { get; }
    IIntersectionCurve Item { get; }
    IEnumerator GetEnumerator();
    IIntersectionCurve Add(object EntityOne, object EntityTwo);
}
