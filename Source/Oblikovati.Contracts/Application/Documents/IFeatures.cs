using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ChamferFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    CircularPatternFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ClientFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ExtrudeFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.FaceOffsetFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.FilletFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MidSurfaceFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MirrorFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MoveFaceFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    RectangularPatternFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.RevolveFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SweepFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ThreadFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents;

public interface IFeatures : IList<IFeatures>
{
    IPartFeature Item { get; }

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

    IPath CreatePath(object SketchCurve);
    IPath CreateSpecifiedPath(IObjectCollection SketchCurves);
}