using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    RuledSurfaceFeature;

public interface IRuledSurfaceFeatures : IList<IRuledSurfaceFeatures>
{
    IRuledSurfaceFeature Item { get; }
    IRuledSurfaceFeature Add(IRuledSurfaceDefinition Definition);

    IRuledSurfaceDefinition CreateDefinition(RuledSurfaceTypeEnum RuledSurfaceType, object GeneratrixCurves,
        object Distance, object Vector);

    IRuledSurfaceEdgeFacePairs CreateRuledSurfaceEdgeFacePairs();
}