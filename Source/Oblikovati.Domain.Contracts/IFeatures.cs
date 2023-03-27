namespace Oblikovati.Domain.Contracts;

public interface IFeatures : IList<IFeatures>
{

    IPartFeature Item { get; }
    int Count { get; }
    IChamferFeatures ChamferFeatures { get; }
    IExtrudeFeatures ExtrudeFeatures { get; }
    IFilletFeatures FilletFeatures { get; }
    IHoleFeatures HoleFeatures { get; }
    IRevolveFeatures RevolveFeatures { get; }
    ISweepFeatures SweepFeatures { get; }
    IRectangularPatternFeatures RectangularPatternFeatures { get; }
    ICircularPatternFeatures CircularPatternFeatures { get; }
    IMirrorFeatures MirrorFeatures { get; }
    ISketchDrivenPatternFeatures SketchDrivenPatternFeatures { get; }
    IMoveFaceFeatures MoveFaceFeatures { get; }
    IClientFeatures ClientFeatures { get; }
    IFaceOffsetFeatures FaceOffsetFeatures { get; }
    IMidSurfaceFeatures MidSurfaceFeatures { get; }
    IThreadFeatures ThreadFeatures { get; }
    IEnumerator GetEnumerator();
    IPath CreatePath(object SketchCurve);
    IPath CreateSpecifiedPath(IObjectCollection SketchCurves);
}
