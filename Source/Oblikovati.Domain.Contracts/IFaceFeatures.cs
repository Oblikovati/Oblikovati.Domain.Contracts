namespace Oblikovati.Domain.Contracts;

public interface IFaceFeatures : IList<IFaceFeatures>
{

    IFaceFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IFaceFeature Add(IFaceFeatureDefinition FaceFeatureDefinition);
    IFaceFeatureDefinition CreateFaceFeatureDefinition(IProfile Profile);
}
