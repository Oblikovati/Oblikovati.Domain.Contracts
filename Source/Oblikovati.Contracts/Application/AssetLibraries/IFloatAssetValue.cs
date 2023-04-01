using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.AssetLibraries;

public interface IFloatAssetValue
{
    IAsset Parent { get; }
    string DisplayName { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    AssetValueTypeEnum ValueType { get; }
    IAssetTexture ConnectedTexture { get; }
    bool HasConnectedTexture { get; set; }
    bool HasLimits { get; }
    bool IsPercentage { get; }
    string Units { get; }
    double Value { get; set; }
    bool HasMultipleValues { get; }
    List<double> Values { get; set; }
    void GetLimits(out bool HasLowLimit, out double LowLimit, out bool HasHighLimit, out double HighLimit);
}