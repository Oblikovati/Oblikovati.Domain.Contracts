namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDynamicSimulations : IList<IDynamicSimulations>
{
    IDynamicSimulation Item { get; }
}