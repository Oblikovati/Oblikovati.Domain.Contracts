using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAssetTexture : IList<IAssetTexture>
{

    int Count { get; }
    IAssetValue Item { get; }
    AssetTextureTypeEnum TextureType { get; }
    IEnumerator GetEnumerator();
    void ChangeTextureType(AssetTextureTypeEnum TextureType, object ImageFilename);
}
