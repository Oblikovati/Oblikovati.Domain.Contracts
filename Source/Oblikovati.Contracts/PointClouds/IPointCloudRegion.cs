using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.PointClouds;

public interface IPointCloudRegion
{
    IColor Color { get; }
    string DisplayName { get; }
    string InternalName { get; }
    IPointCloud Parent { get; }
    bool Visible { get; set; }
}