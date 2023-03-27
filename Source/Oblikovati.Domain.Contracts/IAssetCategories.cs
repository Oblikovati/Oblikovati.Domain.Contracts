namespace Oblikovati.Domain.Contracts;

public interface IAssetCategories : IList<IAssetCategories>
{

    int Count { get; }
    IAssetCategory Item { get; }
    IEnumerator GetEnumerator();
    IAssetCategory Add(string DisplayName, IAsset Asset);
}
