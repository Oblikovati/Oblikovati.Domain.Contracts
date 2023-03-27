namespace Oblikovati.Domain.Contracts;

public interface IDrawingBOMRows : IList<IDrawingBOMRows>
{

    int Count { get; }
    IDrawingBOMRow Item { get; }
    IEnumerator GetEnumerator();
}
