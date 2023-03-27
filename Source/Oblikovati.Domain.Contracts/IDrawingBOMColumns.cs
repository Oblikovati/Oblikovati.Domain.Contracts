namespace Oblikovati.Domain.Contracts;

public interface IDrawingBOMColumns : IList<IDrawingBOMColumns>
{

    int Count { get; }
    IDrawingBOMColumn Item { get; }
    IEnumerator GetEnumerator();
}
