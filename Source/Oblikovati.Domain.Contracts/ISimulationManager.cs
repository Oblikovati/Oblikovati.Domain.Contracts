namespace Oblikovati.Domain.Contracts;

public interface ISimulationManager
{

    IDynamicSimulations DynamicSimulations { get; }
    IComponentDefinition Parent { get; }
}
