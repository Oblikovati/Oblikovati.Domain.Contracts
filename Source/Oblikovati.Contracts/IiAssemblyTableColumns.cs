namespace Oblikovati.Contracts;

public interface IiAssemblyTableColumns : IList<IiAssemblyTableColumns>
{
    IiAssemblyTableColumn Item { get; }
}