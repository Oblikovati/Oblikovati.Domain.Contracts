namespace Oblikovati.Domain.Contracts;

public interface ISketches3D : IList<ISketches3D>
{
    ISketch3D Item { get; }

    int Count { get; }
    IEnumerator GetEnumerator();
    ISketch3D Add();
}
