namespace Oblikovati.Domain.Contracts;

public interface ILoftedFlangeFeatures : IList<ILoftedFlangeFeatures>
{

    ILoftedFlangeFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ILoftedFlangeFeature Add(ILoftedFlangeDefinition LoftedFlangeDefinition);
    ILoftedFlangeDefinition CreateLoftedFlangeDefinition(IPath ProfileOne, IPath ProfileTwo);
}
