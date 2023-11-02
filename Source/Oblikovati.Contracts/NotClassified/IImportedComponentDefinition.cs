namespace Oblikovati.Contracts.NotClassified;

public interface IImportedComponentDefinition
{
    IImportedComponent Parent { get; }
    string FullFileName { get; }
}