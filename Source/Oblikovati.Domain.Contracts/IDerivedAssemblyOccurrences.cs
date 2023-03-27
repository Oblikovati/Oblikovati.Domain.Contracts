namespace Oblikovati.Domain.Contracts;

public interface IDerivedAssemblyOccurrences : IList<IDerivedAssemblyOccurrences>
{
    int Count { get; }
    IDerivedAssemblyOccurrence Item { get; }

    IEnumerator GetEnumerator();
}
