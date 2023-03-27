namespace Oblikovati.Domain.Contracts;

public interface IDrawingBOMRow : IList<IDrawingBOMRow>
{

    IBOMRow BOMRow { get; }
    int Count { get; }
    bool Ballooned { get; }
    bool Custom { get; }
    bool Virtual { get; }
    IDrawingBOMCell Item { get; }
    IDrawingBOM Parent { get; }
    IEnumerator GetEnumerator();
}
