using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IFaceOffsetPreview
{
    void _Preview(IFaceCollection InputFaces, object Distance, bool reverse, bool autoFaceChain, bool IsOptimized,
        object ApproxTol, FeatureApproximationTypeEnum approxType, out ISurfaceBodies pBodies);
}