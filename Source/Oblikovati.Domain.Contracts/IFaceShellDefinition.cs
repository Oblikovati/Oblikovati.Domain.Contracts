namespace Oblikovati.Domain.Contracts;

public interface IFaceShellDefinition
{

    IFaceDefinitions FaceDefinitions { get; }
    IWireDefinitions WireDefinitions { get; }
}
