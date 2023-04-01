namespace Oblikovati.Contracts.Application.TransientBRep;

public interface IFaceShellDefinition
{
    IFaceDefinitions FaceDefinitions { get; }
    IWireDefinitions WireDefinitions { get; }
}