using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.DynamicSimulation;

namespace Oblikovati.Contracts.NotClassified;

public interface ISimulationManager
{
    IDynamicSimulations DynamicSimulations { get; }
    IComponentDefinition Parent { get; }
}