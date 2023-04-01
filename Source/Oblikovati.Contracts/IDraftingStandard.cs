using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IDraftingStandard
{
    DraftingStandardEnum BaseStandard { get; }
    bool BuiltIn { get; }
    string Name { get; }
    string _DisplayName { get; }
}