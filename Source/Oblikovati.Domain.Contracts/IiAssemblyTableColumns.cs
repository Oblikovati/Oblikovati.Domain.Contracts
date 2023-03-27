namespace Oblikovati.Domain.Contracts;

public interface IiAssemblyTableColumns : IList<IiAssemblyTableColumns>
{

    int Count { get; }
    IiAssemblyTableColumn Item { get; }
    IEnumerator GetEnumerator();
}
