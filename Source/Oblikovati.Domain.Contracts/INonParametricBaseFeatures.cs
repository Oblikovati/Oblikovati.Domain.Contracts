namespace Oblikovati.Domain.Contracts;

public interface INonParametricBaseFeatures : IList<INonParametricBaseFeatures>
{

    INonParametricBaseFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    INonParametricBaseFeature Add(ISurfaceBody SurfaceBody, object Transform);
    INonParametricBaseFeature AddByDefinition(INonParametricBaseFeatureDefinition Definition);
    INonParametricBaseFeatureDefinition CreateDefinition();
}
