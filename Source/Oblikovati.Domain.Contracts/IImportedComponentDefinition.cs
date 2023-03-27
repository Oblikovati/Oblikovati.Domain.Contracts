namespace Oblikovati.Domain.Contracts;

public interface IImportedComponentDefinition
{

    IImportedComponent Parent { get; }
    string FullFileName { get; }
}
