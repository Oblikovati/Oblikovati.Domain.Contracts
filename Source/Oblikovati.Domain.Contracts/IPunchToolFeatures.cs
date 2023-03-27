namespace Oblikovati.Domain.Contracts;

public interface IPunchToolFeatures : IList<IPunchToolFeatures>
{

    IPunchToolFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IPunchToolFeature _Add(IObjectCollection PunchCenterPoints, IiFeatureDefinition Definition, object Angle);
    IPunchToolFeature Add(IObjectCollection PunchCenterPoints, IiFeatureDefinition Definition, object Angle, bool AcrossBends);
    IiFeatureDefinition CreateiFeatureDefinition(string FullFileName);
}
