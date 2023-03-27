using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelToleranceFeatures : IList<IModelToleranceFeatures>
{
    int Count { get; }
    IModelToleranceFeature Item { get; }
    IEnumerator GetEnumerator();
    IModelToleranceFeature Add(IModelToleranceFeatureDefinition Definition, object ClientId);
    IModelToleranceFeature Rebuild(IModelToleranceFeatureDefinition Definition, IModelToleranceFeature __MIDL__ModelToleranceFeatures0000, object ClientId);
    IModelToleranceFeatureDefinition CreateDefinition(ModelToleranceFeatureTypeEnum FeatureType, object Faces);
    IModelToleranceFeature GetToleranceFeatureFromFace(IFace Face);
    void UpdateStatusVisualization();
    void CreateStatusVisualization();
    void RemoveStatusVisualization();
    bool StatusVisualized();
}
