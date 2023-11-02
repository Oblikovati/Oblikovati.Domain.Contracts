using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    FaceOffsetFeature;

public interface IFaceOffsetFeatures : IList<IFaceOffsetFeatures>
{
    IFaceOffsetFeature _Item { get; }
    int _Count { get; }

    IFaceOffsetFeature _Add(uint simulationId, IFaceOffsetDefinition Definition);

    IFaceOffsetDefinition _CreateFaceOffsetDefinition(object Faces, object Distance, bool Direction,
        bool AutomaticFaceChain, bool IsOptimized, object ApproxTol, FeatureApproximationTypeEnum approxType);

    IFaceOffsetPreview _GetFaceOffsetPreview();
}