namespace Oblikovati.Contracts.PointClouds;

public interface IPointCloudScans : IList<IPointCloudScans>
{
    IPointCloudScan Item { get; }
}