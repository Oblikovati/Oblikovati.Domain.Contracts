using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFaceOffsetPreview
{
    void _Preview(IFaceCollection InputFaces, object Distance, bool reverse, bool autoFaceChain, bool IsOptimized, object ApproxTol, FeatureApproximationTypeEnum approxType, out ISurfaceBodies pBodies);
}
