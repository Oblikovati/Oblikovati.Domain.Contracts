namespace Oblikovati.Domain.Contracts;

public interface IFaces : IList<IFaces>
{
    IFace Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
