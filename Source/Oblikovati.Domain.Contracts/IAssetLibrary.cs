namespace Oblikovati.Domain.Contracts;

public interface IAssetLibrary
{

    IAssetCategories AppearanceAssetCategories { get; }
    IAssetsEnumerator AppearanceAssets { get; }
    string DisplayName { get; set; }
    string FullFileName { get; }
    string InternalName { get; }
    bool IsReadOnly { get; }
    IAssetCategories MaterialAssetCategories { get; }
    IAssetsEnumerator MaterialAssets { get; }
    IAssetsEnumerator PhysicalAssets { get; }
    void Remove();
}
