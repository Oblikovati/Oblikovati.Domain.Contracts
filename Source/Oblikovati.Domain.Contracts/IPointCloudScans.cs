namespace Oblikovati.Domain.Contracts;

public interface IPointCloudScans : IList<IPointCloudScans>
{

    IPointCloudScan Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
