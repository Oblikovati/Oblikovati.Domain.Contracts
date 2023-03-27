namespace Oblikovati.Domain.Contracts;

public interface IMapPointCurves : IList<IMapPointCurves>
{

    IMapPointCurve Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IMapPointCurve AddMapCurve();
}
