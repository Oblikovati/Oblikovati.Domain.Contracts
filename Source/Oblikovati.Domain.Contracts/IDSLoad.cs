using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDSLoad
{

    IDSLoadDefinition Definition { get; set; }
    DSLoadTypeEnum LoadType { get; }
    string Name { get; set; }
    bool IsSuppressed { get; set; }
}
