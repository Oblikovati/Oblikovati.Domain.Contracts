namespace Oblikovati.Domain.Contracts;

public interface IPartFeatures : IList<IPartFeatures>
{

    IPartFeature Item { get; }
    int Count { get; }
    INonParametricBaseFeature NonParametricBaseFeature { get; }
    IChamferFeatures ChamferFeatures { get; }
    ICircularPatternFeatures CircularPatternFeatures { get; }
    ICoilFeatures CoilFeatures { get; }
    IDecalFeatures DecalFeatures { get; }
    IDeleteFaceFeatures DeleteFaceFeatures { get; }
    IEmbossFeatures EmbossFeatures { get; }
    IExtrudeFeatures ExtrudeFeatures { get; }
    IFaceDraftFeatures FaceDraftFeatures { get; }
    IFilletFeatures FilletFeatures { get; }
    IFreeformFeatures FreeformFeatures { get; }
    IDirectEditFeatures DirectEditFeatures { get; }
    IHoleFeatures HoleFeatures { get; }
    IKnitFeatures KnitFeatures { get; }
    IBoundaryPatchFeatures BoundaryPatchFeatures { get; }
    ILoftFeatures LoftFeatures { get; }
    IMirrorFeatures MirrorFeatures { get; }
    INonParametricBaseFeatures NonParametricBaseFeatures { get; }
    IRectangularPatternFeatures RectangularPatternFeatures { get; }
    ISketchDrivenPatternFeatures SketchDrivenPatternFeatures { get; }
    IReplaceFaceFeatures ReplaceFaceFeatures { get; }
    IRevolveFeatures RevolveFeatures { get; }
    IRibFeatures RibFeatures { get; }
    IRuledSurfaceFeatures RuledSurfaceFeatures { get; }
    IShellFeatures ShellFeatures { get; }
    ISplitFeatures SplitFeatures { get; }
    ISweepFeatures SweepFeatures { get; }
    IThickenFeatures ThickenFeatures { get; }
    IThreadFeatures ThreadFeatures { get; }
    IReferenceFeatures ReferenceFeatures { get; }
    IMoveFaceFeatures MoveFaceFeatures { get; }
    ISculptFeatures SculptFeatures { get; }
    ITrimFeatures TrimFeatures { get; }
    IExtendFeatures ExtendFeatures { get; }
    IClientFeatures ClientFeatures { get; }
    IBendPartFeatures BendPartFeatures { get; }
    IiFeatures iFeatures { get; }
    ICombineFeatures CombineFeatures { get; }
    IMoveFeatures MoveFeatures { get; }
    IBossFeatures BossFeatures { get; }
    IGrillFeatures GrillFeatures { get; }
    ILipFeatures LipFeatures { get; }
    IRestFeatures RestFeatures { get; }
    IRuleFilletFeatures RuleFilletFeatures { get; }
    ISnapFitFeatures SnapFitFeatures { get; }
    IUnwrapFeatures UnwrapFeatures { get; }
    ICoreCavityFeatures CoreCavityFeatures { get; }
    IAliasFreeformFeatures AliasFreeformFeatures { get; }
    IMidSurfaceFeatures MidSurfaceFeatures { get; }
    IFaceOffsetFeatures FaceOffsetFeatures { get; }
    IEnumerator GetEnumerator();
    IPath CreatePath(object SketchCurve);
    IPath CreateSpecifiedPath(IObjectCollection SketchCurves);
}
