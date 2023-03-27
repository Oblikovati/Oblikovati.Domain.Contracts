namespace Oblikovati.Domain.Contracts;

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
