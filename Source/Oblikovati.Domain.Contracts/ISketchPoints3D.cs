namespace Oblikovati.Domain.Contracts;

public interface ISketchPoints3D : IList<ISketchPoints3D>
{

    int Count { get; }
    ISketchPoint3D Item { get; }
    IEnumerator GetEnumerator();
    ISketchPoint3D Add(IPoint Point, bool HoleCenter);
}
