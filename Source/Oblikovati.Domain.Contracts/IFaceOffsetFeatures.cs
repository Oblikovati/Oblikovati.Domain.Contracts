using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFaceOffsetFeatures : IList<IFaceOffsetFeatures>
{

    IFaceOffsetFeature _Item { get; }
    int _Count { get; }
    IEnumerator GetEnumerator();
    IFaceOffsetFeature _Add(uint simulationId, IFaceOffsetDefinition Definition);
    IFaceOffsetDefinition _CreateFaceOffsetDefinition(object Faces, object Distance, bool Direction, bool AutomaticFaceChain, bool IsOptimized, object ApproxTol, FeatureApproximationTypeEnum approxType);
    IFaceOffsetPreview _GetFaceOffsetPreview();
}
