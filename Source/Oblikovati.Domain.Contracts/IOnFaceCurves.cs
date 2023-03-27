namespace Oblikovati.Domain.Contracts;

public interface IOnFaceCurves : IList<IOnFaceCurves>
{

    int Count { get; }
    IOnFaceCurve Item { get; }
    IEnumerator GetEnumerator();
    IOnFaceCurve Add(INameValueMap Faces, INameValueMap FitPoints);
}
