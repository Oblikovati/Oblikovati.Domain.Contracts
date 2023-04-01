using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.PointClouds;

public interface IPointCloudCrop
{
    IOrientedBox BoundingBox { get; }
    bool KeepInside { get; }
    IPointCloud Parent { get; }
}