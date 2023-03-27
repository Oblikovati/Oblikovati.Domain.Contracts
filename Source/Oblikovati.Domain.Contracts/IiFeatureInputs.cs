namespace Oblikovati.Domain.Contracts;

public interface IiFeatureInputs : IList<IiFeatureInputs>
{

    int Count { get; }
    IiFeatureInput Item { get; }
    IEnumerator GetEnumerator();
}
