namespace Oblikovati.Domain.Contracts;

public interface IPointCloudCrops : IList<IPointCloudCrops>
{

    IPointCloudCrop Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IPointCloudCrop Add(IOrientedBox BoundingBox, bool KeepInside);
    void Clear();
}
