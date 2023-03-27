namespace Oblikovati.Domain.Contracts;

public interface IDerivedParameters : IList<IDerivedParameters>
{
    IDerivedParameter Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
