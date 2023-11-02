using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MeshFeature;
using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.NotClassified;

public interface IMeshVertex
{
    IPoint Geometry { get; }
    IMeshFeature MeshFeature { get; }
    IMeshFeatureEntity MeshFeatureEntity { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}