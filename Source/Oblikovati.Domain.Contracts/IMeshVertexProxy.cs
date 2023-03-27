namespace Oblikovati.Domain.Contracts;

public interface IMeshVertexProxy
{

    IPoint Geometry { get; }
    IMeshFeature MeshFeature { get; }
    IMeshFeatureEntity MeshFeatureEntity { get; }
    IMeshVertex NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
