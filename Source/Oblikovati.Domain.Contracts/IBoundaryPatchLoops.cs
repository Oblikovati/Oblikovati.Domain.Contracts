namespace Oblikovati.Domain.Contracts;

public interface IBoundaryPatchLoops : IList<IBoundaryPatchLoops>
{

    IBoundaryPatchLoop Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IBoundaryPatchLoop Add(object BoundaryPath);
}
