using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMaterialAsset : IList<IMaterialAsset>
{

    int Count { get; }
    IAssetValue Item { get; }

    AssetTypeEnum AssetType { get; }
    IAssetCategory Category { get; set; }
    string CategoryName { get; }
    string DisplayName { get; set; }
    bool IsReadOnly { get; }
    bool IsUsed { get; }
    string Name { get; }
    bool HasTexture { get; }
    IAsset AppearanceAsset { get; set; }
    IAsset PhysicalPropertiesAsset { get; set; }
    IEnumerator GetEnumerator();
    IAsset CopyTo(object Target, object ReplaceExisting);
    void Delete();
    IAsset Duplicate(object NewDisplayName);
    void _GetProteinAsset(out List<byte> assetBinary, out string referenceLabel);
}
