using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDSLoad
{
    IDSLoadDefinition Definition { get; set; }
    DSLoadTypeEnum LoadType { get; }
    string Name { get; set; }
    bool IsSuppressed { get; set; }
}