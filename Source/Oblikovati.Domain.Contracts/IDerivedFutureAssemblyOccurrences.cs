namespace Oblikovati.Domain.Contracts;

public interface IDerivedFutureAssemblyOccurrences : IList<IDerivedFutureAssemblyOccurrences>
{
    int Count { get; }
    IDerivedFutureAssemblyOccurrence Item { get; }

    IEnumerator GetEnumerator();
}
