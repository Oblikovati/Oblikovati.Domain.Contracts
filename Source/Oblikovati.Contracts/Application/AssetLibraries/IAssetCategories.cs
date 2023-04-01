namespace Oblikovati.Contracts.Application.AssetLibraries;

public interface IAssetCategories : IList<IAssetCategories>
{
    IAssetCategory Item { get; }

    IAssetCategory Add(string DisplayName, IAsset Asset);
}