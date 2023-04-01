using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.PointClouds;

public interface IPointClouds : IList<IPointClouds>
{
    IPointCloud Item { get; }
    IComponentDefinition Parent { get; }


    IPointCloud Add(string PointCloudFilename, object Transform, object Scale, object Options);
}