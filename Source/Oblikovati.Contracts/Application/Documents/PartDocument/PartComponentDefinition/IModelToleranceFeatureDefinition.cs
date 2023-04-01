using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.ModelAnnotations;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

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