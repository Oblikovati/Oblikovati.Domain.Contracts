namespace Oblikovati.Domain.Contracts;

public interface IDynamicSimulations : IList<IDynamicSimulations>
{

    int Count { get; }
    IDynamicSimulation Item { get; }
    IEnumerator GetEnumerator();
}
