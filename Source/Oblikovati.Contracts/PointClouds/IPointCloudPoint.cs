using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.PointClouds;

public interface IPointCloudPoint
{
    IPointCloud Parent { get; }
    IPoint Geometry { get; }
}