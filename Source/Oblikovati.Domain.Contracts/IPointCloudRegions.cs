namespace Oblikovati.Domain.Contracts;

public interface IPointCloudRegions : IList<IPointCloudRegions>
{

    IPointCloudRegion Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
