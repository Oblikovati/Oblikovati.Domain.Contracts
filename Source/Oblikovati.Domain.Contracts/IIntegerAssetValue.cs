using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIntegerAssetValue
{

    IAsset Parent { get; }
    string DisplayName { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    AssetValueTypeEnum ValueType { get; }
    bool HasLimits { get; }
    int Value { get; set; }
    bool HasMultipleValues { get; }
    List<int> Values { get; set; }
    void GetLimits(out bool HasLowLimit, out int LowLimit, out bool HasHighLimit, out int HighLimit);
}
