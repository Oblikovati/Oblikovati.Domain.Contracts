namespace Oblikovati.Domain.Contracts;

public interface IFeatureDimensions : IList<IFeatureDimensions>
{

    int Count { get; }
    IFeatureDimension Item { get; }
    IEnumerator GetEnumerator();
    void Show();
}
