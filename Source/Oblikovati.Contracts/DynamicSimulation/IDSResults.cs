namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDSResults : IList<IDSResults>
{
    IDSResult Item { get; }
    IDSResult ItemByResultType { get; }
}