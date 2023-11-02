namespace Oblikovati.Contracts.NotClassified;

public interface IiAssemblyTableColumns : IList<IiAssemblyTableColumns>
{
    IiAssemblyTableColumn Item { get; }
}