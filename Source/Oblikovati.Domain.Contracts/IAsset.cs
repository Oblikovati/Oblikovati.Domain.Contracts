using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAsset : IList<IAsset>
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
    IEnumerator GetEnumerator();
    IAsset CopyTo(object Target, object ReplaceExisting);
    void Delete();
    IAsset Duplicate(object NewDisplayName);
    void _GetProteinAsset(out List<byte> assetBinary, out string referenceLabel);
}
