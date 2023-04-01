namespace Oblikovati.Contracts.Application.AssetLibraries;

public interface IAssetCategory
{
    IAssetLibrary Parent { get; }
    IAssetsEnumerator Assets { get; }
    string DisplayName { get; set; }
    void AddAsset(IAsset Asset);
    void Delete();
}