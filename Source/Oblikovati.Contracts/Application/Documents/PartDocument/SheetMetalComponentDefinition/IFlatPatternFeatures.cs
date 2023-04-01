using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ChamferFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    CircularPatternFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ClientFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.CosmeticBendFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.EmbossFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ExtrudeFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.FilletFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MirrorFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    RectangularPatternFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.RevolveFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SweepFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerChamferFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerRoundFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CutFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    PunchToolFeature;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;

public interface IFlatPatternFeatures : IList<IFlatPatternFeatures>
{
    IPartFeature Item { get; }

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

    IPath CreatePath(object SketchCurve);
}