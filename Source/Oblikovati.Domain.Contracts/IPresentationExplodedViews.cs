namespace Oblikovati.Domain.Contracts;

public interface IPresentationExplodedViews : IList<IPresentationExplodedViews>
{

    IPresentationExplodedView Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
