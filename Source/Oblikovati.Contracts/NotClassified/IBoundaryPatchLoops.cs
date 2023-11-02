namespace Oblikovati.Contracts.NotClassified;

public interface IBoundaryPatchLoops : IList<IBoundaryPatchLoops>
{
    IBoundaryPatchLoop Item { get; }


    IBoundaryPatchLoop Add(object BoundaryPath);
}