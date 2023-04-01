using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;

public interface IiFeatureTable
{
    IiFeatureTableRow DefaultRow { get; set; }
    IiFeatureTableColumns iFeatureTableColumns { get; }
    IiFeatureTableRows iFeatureTableRows { get; }
    object ExcelWorkSheet { get; }
    void Delete();
    void Export(string FileName, FileFormatEnum FileFormat, object Options);
}