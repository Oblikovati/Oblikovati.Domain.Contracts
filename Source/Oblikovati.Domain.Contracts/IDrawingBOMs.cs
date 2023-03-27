namespace Oblikovati.Domain.Contracts;

public interface IDrawingBOMs : IList<IDrawingBOMs>
{

    int Count { get; }
    IDrawingBOM Item { get; }
    bool IsDrawingBOMDefined(string FullFileName);
    IEnumerator GetEnumerator();
}
