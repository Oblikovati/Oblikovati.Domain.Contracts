using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.AssetLibraries;

public interface IAssets : IList<IAssets>
{
    IAsset Item { get; }

    IAsset Add(AssetTypeEnum AssetType, string LocalType, object Reserved, object DisplayName);
}