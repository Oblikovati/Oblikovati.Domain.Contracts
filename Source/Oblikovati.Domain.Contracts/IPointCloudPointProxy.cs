namespace Oblikovati.Domain.Contracts;

public interface IPointCloudPointProxy
{

    IPointCloud Parent { get; }
    IPoint Geometry { get; }
    IPointCloudPoint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
