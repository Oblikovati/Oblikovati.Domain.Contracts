using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.PointClouds;

public interface IPointCloudCrops : IList<IPointCloudCrops>
{
    IPointCloudCrop Item { get; }
    IPointCloudCrop Add(IOrientedBox BoundingBox, bool KeepInside);
}