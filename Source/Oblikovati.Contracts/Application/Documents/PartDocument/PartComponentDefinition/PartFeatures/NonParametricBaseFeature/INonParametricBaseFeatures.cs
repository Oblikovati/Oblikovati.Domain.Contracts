namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    NonParametricBaseFeature;

public interface INonParametricBaseFeatures : IList<INonParametricBaseFeatures>
{
    INonParametricBaseFeature Item { get; }


    INonParametricBaseFeature Add(ISurfaceBody SurfaceBody, object Transform);
    INonParametricBaseFeature AddByDefinition(INonParametricBaseFeatureDefinition Definition);
    INonParametricBaseFeatureDefinition CreateDefinition();
}