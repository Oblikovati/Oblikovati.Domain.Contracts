namespace Oblikovati.Contracts;

public interface IiAssemblyTableRows : IList<IiAssemblyTableRows>
{
    IiAssemblyTableRow Item { get; }
}