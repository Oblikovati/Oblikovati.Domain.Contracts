namespace Oblikovati.Domain.Contracts;

public interface IDrawingViewHatchRegions : IList<IDrawingViewHatchRegions>
{

    IDrawingViewHatchRegion Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
