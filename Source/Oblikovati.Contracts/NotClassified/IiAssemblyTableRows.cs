namespace Oblikovati.Contracts.NotClassified;

public interface IiAssemblyTableRows : IList<IiAssemblyTableRows>
{
    IiAssemblyTableRow Item { get; }
}