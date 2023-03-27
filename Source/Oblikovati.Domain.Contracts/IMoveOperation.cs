namespace Oblikovati.Domain.Contracts;

public interface IMoveOperation
{

    IMoveDefinition Parent { get; }
    void Delete();
}
