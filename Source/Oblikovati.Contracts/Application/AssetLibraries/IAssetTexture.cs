using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.AssetLibraries;

public interface IAssetTexture : IList<IAssetTexture>
{
    IAssetValue Item { get; }
    AssetTextureTypeEnum TextureType { get; }

    void ChangeTextureType(AssetTextureTypeEnum TextureType, object ImageFilename);
}