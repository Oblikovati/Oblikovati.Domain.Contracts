namespace Oblikovati.Domain.Contracts;

public interface IiAssemblyTableRows : IList<IiAssemblyTableRows>
{

    int Count { get; }
    IiAssemblyTableRow Item { get; }
    IEnumerator GetEnumerator();
}
