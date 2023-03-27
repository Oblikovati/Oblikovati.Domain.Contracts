namespace Oblikovati.Domain.Contracts;

public interface IBOMViews : IList<IBOMViews>
{

    int Count { get; }
    IBOMView Item { get; }
    IEnumerator GetEnumerator();
}
