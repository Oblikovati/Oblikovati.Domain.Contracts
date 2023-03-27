namespace Oblikovati.Domain.Contracts;

public interface ISketchFillRegions : IList<ISketchFillRegions>
{

    ISketchFillRegion Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ISketchFillRegion Add(IProfile Profile, object Color);
}
