namespace Oblikovati.Domain.Contracts;

public interface IiFeatureDefinition
{

    IiFeatureInputs iFeatureInputs { get; }
    IiFeatureTable iFeatureTable { get; }
    bool IsTableDriven { get; }
    bool IsPunchTool { get; }
    string PunchId { get; }
    IiFeatureTableRow ActiveTableRow { get; set; }
}
