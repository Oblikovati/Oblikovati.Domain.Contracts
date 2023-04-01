namespace Oblikovati.Contracts;

public interface IImportedComponentDefinition
{
    IImportedComponent Parent { get; }
    string FullFileName { get; }
}