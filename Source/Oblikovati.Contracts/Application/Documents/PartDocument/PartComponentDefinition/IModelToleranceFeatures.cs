using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IModelToleranceFeatures : IList<IModelToleranceFeatures>
{
    IModelToleranceFeature Item { get; }

    IModelToleranceFeature Add(IModelToleranceFeatureDefinition Definition, object ClientId);

    IModelToleranceFeature Rebuild(IModelToleranceFeatureDefinition Definition,
        IModelToleranceFeature __MIDL__ModelToleranceFeatures0000, object ClientId);

    IModelToleranceFeatureDefinition CreateDefinition(ModelToleranceFeatureTypeEnum FeatureType, object Faces);
    IModelToleranceFeature GetToleranceFeatureFromFace(IFace Face);
    void UpdateStatusVisualization();
    void CreateStatusVisualization();
    void RemoveStatusVisualization();
    bool StatusVisualized();
}