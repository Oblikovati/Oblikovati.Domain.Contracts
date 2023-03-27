namespace Oblikovati.Domain.Contracts;

public interface ISketchEllipticalArcs3D : IList<ISketchEllipticalArcs3D>
{

    int Count { get; }
    ISketchEllipticalArc3D Item { get; }
    IEnumerator GetEnumerator();
}
