namespace Oblikovati.Domain.Contracts;

public interface IPointClouds : IList<IPointClouds>
{

    IPointCloud Item { get; }
    IComponentDefinition Parent { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IPointCloud Add(string PointCloudFilename, object Transform, object Scale, object Options);
}
