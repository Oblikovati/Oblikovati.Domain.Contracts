using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IChoiceAssetValue
{

    IAsset Parent { get; }
    string DisplayName { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    AssetValueTypeEnum ValueType { get; }
    string Value { get; set; }
    void GetChoices(out List<string> Names, out List<string> Choices);
}
