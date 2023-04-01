namespace Oblikovati.Contracts.Sketch3D;

public interface ISilhouetteCurves : IList<ISilhouetteCurves>
{
    ISilhouetteCurve Item { get; }

    ISilhouetteCurve Add(object FacesOrBody, object DirectionEntity, bool IncludeCoincidentSilhouettes);

    ISilhouetteCurve AddSilhouette(ISurfaceBody Body, object DirectionEntity, object ExcludedFaces,
        object ExcludeStraightFaces, object ExcludeInteralFaces);
}