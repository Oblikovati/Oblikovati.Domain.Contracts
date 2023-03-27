namespace Oblikovati.Domain.Contracts;

public interface IDerivedPartEntities : IList<IDerivedPartEntities>
{
    int Count { get; }
    IDerivedPartEntity Item { get; }

    IEnumerator GetEnumerator();
}
