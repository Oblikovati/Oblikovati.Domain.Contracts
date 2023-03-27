namespace Oblikovati.Domain.Contracts;

public interface IDrawingViewHatchAreas : IList<IDrawingViewHatchAreas>
{

    IDrawingViewHatchArea Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
