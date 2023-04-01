using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.AssetLibraries;

public interface IColorAssetValue
{
    IAsset Parent { get; }
    string DisplayName { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    AssetValueTypeEnum ValueType { get; }
    IAssetTexture ConnectedTexture { get; }
    bool HasConnectedTexture { get; set; }
    IColor Value { get; set; }
    bool HasMultipleValues { get; }
    List<IColor> Values { get; set; }
}