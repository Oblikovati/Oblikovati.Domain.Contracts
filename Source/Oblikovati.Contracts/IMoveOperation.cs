namespace Oblikovati.Contracts;

public interface IMoveOperation
{
    IMoveDefinition Parent { get; }
    void Delete();
}