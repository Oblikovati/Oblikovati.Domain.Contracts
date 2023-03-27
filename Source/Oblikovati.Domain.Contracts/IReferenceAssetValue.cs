using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IReferenceAssetValue
{

    IAsset Parent { get; }
    string DisplayName { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    AssetValueTypeEnum ValueType { get; }
    IAsset Value { get; set; }
    bool HasMultipleValues { get; }
    List<IAsset> Values { get; set; }
}
