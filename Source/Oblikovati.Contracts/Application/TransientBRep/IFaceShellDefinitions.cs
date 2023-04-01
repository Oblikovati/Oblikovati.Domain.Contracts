namespace Oblikovati.Contracts.Application.TransientBRep;

public interface IFaceShellDefinitions : IList<IFaceShellDefinitions>
{
    IFaceShellDefinition Item { get; }


    IFaceShellDefinition Add();
}