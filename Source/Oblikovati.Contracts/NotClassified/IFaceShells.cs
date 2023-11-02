namespace Oblikovati.Contracts.NotClassified;

public interface IFaceShells : IList<IFaceShells>
{
    IFaceShell Item { get; }
}