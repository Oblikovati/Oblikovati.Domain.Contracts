using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.AssetLibraries;

public interface IAsset : IList<IAsset>
{
    IAssetValue Item { get; }
    AssetTypeEnum AssetType { get; }
    IAssetCategory Category { get; set; }
    string CategoryName { get; }
    string DisplayName { get; set; }
    bool IsUsed { get; }
    string Name { get; }
    bool HasTexture { get; }
    IAsset CopyTo(object Target, object ReplaceExisting);
    void Delete();
    IAsset Duplicate(object NewDisplayName);
    void _GetProteinAsset(out List<byte> assetBinary, out string referenceLabel);
}