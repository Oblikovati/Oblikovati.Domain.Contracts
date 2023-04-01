using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.ClientGraphics;
using Oblikovati.Contracts.GraphicsDataSets;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ClientFeature;

public interface IClientFeatureDefinition
{
    IClientFeature Parent { get; }
    IClientFeatureElements ClientFeatureElements { get; }
    string FeatureType { get; }
    IClientGraphicsCollection ClientGraphicsCollection { get; }
    IObjectCollection FeatureInputs { get; set; }
    bool IsCustomSolved { get; set; }
    bool HighlightClientGraphicsWithFeature { get; set; }
    IGraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    void AddDependency(object Dependency);
    void RemoveDependency(object Dependency);
}