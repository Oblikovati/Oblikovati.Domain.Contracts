using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBooleanAssetValue
{

    IAsset Parent { get; }
    string DisplayName { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    AssetValueTypeEnum ValueType { get; }
    bool Value { get; set; }
}
