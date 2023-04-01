namespace Oblikovati.Contracts.PointClouds;

public interface IPointCloudRegions : IList<IPointCloudRegions>
{
    IPointCloudRegion Item { get; }
}