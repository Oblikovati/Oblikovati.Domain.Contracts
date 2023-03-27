namespace Oblikovati.Domain.Contracts;

public interface IFlatPatternFeatures : IList<IFlatPatternFeatures>
{

    IPartFeature Item { get; }
    int Count { get; }
    IChamferFeatures ChamferFeatures { get; }
    ICircularPatternFeatures CircularPatternFeatures { get; }
    ICornerChamferFeatures CornerChamferFeatures { get; }
    ICornerRoundFeatures CornerRoundFeatures { get; }
    ICutFeatures CutFeatures { get; }
    IEmbossFeatures EmbossFeatures { get; }
    IExtrudeFeatures ExtrudeFeatures { get; }
    IFilletFeatures FilletFeatures { get; }
    IHoleFeatures HoleFeatures { get; }
    IiFeatures iFeatures { get; }
    IMirrorFeatures MirrorFeatures { get; }
    IPunchToolFeatures PunchToolFeatures { get; }
    IRectangularPatternFeatures RectangularPatternFeatures { get; }
    IRevolveFeatures RevolveFeatures { get; }
    ISweepFeatures SweepFeatures { get; }
    ICosmeticBendFeatures CosmeticBendFeatures { get; }
    IClientFeatures ClientFeatures { get; }
    ISketchDrivenPatternFeatures SketchDrivenPatternFeatures { get; }
    IEnumerator GetEnumerator();
    IPath CreatePath(object SketchCurve);
}
