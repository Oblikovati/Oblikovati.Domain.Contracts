using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDraftingStandard
{
    DraftingStandardEnum BaseStandard { get; }
    bool BuiltIn { get; }
    string Name { get; }
    string _DisplayName { get; }
}
