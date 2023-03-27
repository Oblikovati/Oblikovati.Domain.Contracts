namespace Oblikovati.Domain.Contracts;

public interface ISketchEllipses3D : IList<ISketchEllipses3D>
{

    int Count { get; }
    ISketchEllipse3D Item { get; }
    IEnumerator GetEnumerator();
}
