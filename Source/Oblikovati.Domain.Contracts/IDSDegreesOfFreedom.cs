namespace Oblikovati.Domain.Contracts;

public interface IDSDegreesOfFreedom : IList<IDSDegreesOfFreedom>
{

    int Count { get; }
    IDSDegreeOfFreedom Item { get; }
    IEnumerator GetEnumerator();
}
