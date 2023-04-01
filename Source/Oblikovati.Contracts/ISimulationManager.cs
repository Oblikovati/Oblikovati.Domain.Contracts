using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.DynamicSimulation;

namespace Oblikovati.Contracts;

public interface ISimulationManager
{
    IDynamicSimulations DynamicSimulations { get; }
    IComponentDefinition Parent { get; }
}