using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAssets : IList<IAssets>
{

    int Count { get; }
    IAsset Item { get; }
    IEnumerator GetEnumerator();
    IAsset Add(AssetTypeEnum AssetType, string LocalType, object Reserved, object DisplayName);
}
