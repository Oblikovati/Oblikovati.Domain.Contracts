namespace Oblikovati.Contracts.NotClassified;

public interface IMoveOperation
{
    IMoveDefinition Parent { get; }
    void Delete();
}