namespace Oblikovati.Domain.Contracts;

public interface IReferenceFeatures : IList<IReferenceFeatures>
{

    IReferenceFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
