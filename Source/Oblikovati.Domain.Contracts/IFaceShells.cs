namespace Oblikovati.Domain.Contracts;

public interface IFaceShells : IList<IFaceShells>
{
    IFaceShell Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
