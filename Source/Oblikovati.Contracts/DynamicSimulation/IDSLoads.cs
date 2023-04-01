namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDSLoads : IList<IDSLoads>
{
    IDSLoad Item { get; }
}