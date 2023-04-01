namespace Oblikovati.Contracts;

public interface IBoundaryPatchLoops : IList<IBoundaryPatchLoops>
{
    IBoundaryPatchLoop Item { get; }


    IBoundaryPatchLoop Add(object BoundaryPath);
}