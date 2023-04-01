using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.AssetLibraries;

public interface ITextureAssetValue
{
    IAsset Parent { get; }
    string DisplayName { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    AssetValueTypeEnum ValueType { get; }
    IAssetTexture Value { get; }
}