using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IDraftingStandard
{
    DraftingStandardEnum BaseStandard { get; }
    bool BuiltIn { get; }
    string Name { get; }
    string _DisplayName { get; }
}