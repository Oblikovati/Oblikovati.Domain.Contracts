namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;

public interface IiFeatureDefinition
{
    IiFeatureInputs iFeatureInputs { get; }
    IiFeatureTable iFeatureTable { get; }
    bool IsTableDriven { get; }
    bool IsPunchTool { get; }
    string PunchId { get; }
    IiFeatureTableRow ActiveTableRow { get; set; }
}