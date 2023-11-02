using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.AliasFreeformFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.BossFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.BoundaryPatchFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ChamferFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    CircularPatternFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ClientFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.CoilFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.CombineFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.CoreCavityFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.DecalFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.DeleteFaceFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.DirectEditFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.EmbossFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ExtendFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ExtrudeFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.FaceDraftFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.FaceOffsetFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.FilletFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.FreeformFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.GrillFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.KnitFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.LipFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.LoftFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MidSurfaceFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MirrorFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MoveFaceFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MoveFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    NonParametricBaseFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    RectangularPatternFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ReferenceFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ReplaceFaceFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.RestFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.RevolveFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.RibFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.RuledSurfaceFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.RuleFilletFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SculptFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ShellFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SnapFitFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SplitFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SweepFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ThickenFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ThreadFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.TrimFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.UnwrapFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    ContourFlangeFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    ContourRollFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerChamferFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerRoundFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CutFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    FaceFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    FlangeFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    FoldFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    HemFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    LoftedFlangeFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    PunchToolFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    RefoldFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    RipFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    UnfoldFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures;

public interface ISheetMetalFeatures : IList<ISheetMetalFeatures>
{
    IPartFeature Item { get; }

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
    ICornerFeatures CornerFeatures { get; }
    IBendFeatures BendFeatures { get; }
    ICutFeatures CutFeatures { get; }
    IHemFeatures HemFeatures { get; }
    IFoldFeatures FoldFeatures { get; }
    ICornerRoundFeatures CornerRoundFeatures { get; }
    ICornerChamferFeatures CornerChamferFeatures { get; }
    IFaceFeatures FaceFeatures { get; }
    IFlangeFeatures FlangeFeatures { get; }
    IContourFlangeFeatures ContourFlangeFeatures { get; }
    IPunchToolFeatures PunchToolFeatures { get; }
    IRefoldFeatures RefoldFeatures { get; }
    IUnfoldFeatures UnfoldFeatures { get; }
    IRipFeatures RipFeatures { get; }
    IContourRollFeatures ContourRollFeatures { get; }
    ILoftedFlangeFeatures LoftedFlangeFeatures { get; }

    IPath CreatePath(object SketchCurve);
    IPath CreateSpecifiedPath(IObjectCollection SketchCurves);
}