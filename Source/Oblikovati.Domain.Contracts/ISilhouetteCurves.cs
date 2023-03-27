namespace Oblikovati.Domain.Contracts;

public interface ISilhouetteCurves : IList<ISilhouetteCurves>
{

    int Count { get; }
    ISilhouetteCurve Item { get; }
    IEnumerator GetEnumerator();
    ISilhouetteCurve Add(object FacesOrBody, object DirectionEntity, bool IncludeCoincidentSilhouettes);
    ISilhouetteCurve AddSilhouette(ISurfaceBody Body, object DirectionEntity, object ExcludedFaces, object ExcludeStraightFaces, object ExcludeInteralFaces);
}
