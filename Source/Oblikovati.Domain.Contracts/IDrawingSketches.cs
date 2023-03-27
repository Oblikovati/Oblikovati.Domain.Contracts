namespace Oblikovati.Domain.Contracts;

public interface IDrawingSketches : IList<IDrawingSketches>
{
    IDrawingSketch Item { get; }

    int Count { get; }
    IEnumerator GetEnumerator();
    IDrawingSketch Add();
}
