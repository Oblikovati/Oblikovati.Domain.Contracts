using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRuledSurfaceFeatures : IList<IRuledSurfaceFeatures>
{

    int Count { get; }
    IRuledSurfaceFeature Item { get; }
    IRuledSurfaceFeature Add(IRuledSurfaceDefinition Definition);
    IRuledSurfaceDefinition CreateDefinition(RuledSurfaceTypeEnum RuledSurfaceType, object GeneratrixCurves, object Distance, object Vector);
    IRuledSurfaceEdgeFacePairs CreateRuledSurfaceEdgeFacePairs();
    IEnumerator GetEnumerator();
}
