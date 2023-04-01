using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.PointClouds;

public interface IPointCloudScan
{
    string DisplayName { get; }
    string InternalName { get; }
    IPointCloud Parent { get; }
    string SourceFullFileName { get; }
    bool Visible { get; set; }
    IPoint Origin { get; }
}