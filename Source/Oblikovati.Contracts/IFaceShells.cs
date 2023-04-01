namespace Oblikovati.Contracts;

public interface IFaceShells : IList<IFaceShells>
{
    IFaceShell Item { get; }
}