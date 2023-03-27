namespace Oblikovati.Domain.Contracts;

public interface ICutFeatures : IList<ICutFeatures>
{

    ICutFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ICutFeature Add(ICutDefinition CutDefinition);
    ICutDefinition CreateCutDefinition(IProfile Profile);
}
