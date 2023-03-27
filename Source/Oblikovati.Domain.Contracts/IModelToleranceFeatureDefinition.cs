using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelToleranceFeatureDefinition
{
    IModelToleranceFeature Parent { get; }
    IModelAnnotationsEnumerator Annotations { get; }
    IFaceCollection Faces { get; set; }
    ModelToleranceFeatureTypeEnum FeatureType { get; set; }
    IModelToleranceFeaturesEnumerator SubFeatures { get; }
    void AddAnnotation(IModelAnnotation ModelAnnotation);
    void RemoveAnnotation(IModelAnnotation ModelAnnotation);
    IModelToleranceFeatureDefinition Copy();
    void AddSubFeature(IModelToleranceFeature ModelToleranceFeature);
    void RemoveSubFeature(IModelToleranceFeature ModelToleranceFeature);
}
