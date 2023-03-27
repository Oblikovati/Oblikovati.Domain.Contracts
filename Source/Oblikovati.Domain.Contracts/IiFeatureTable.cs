using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IiFeatureTable
{


    IiFeatureTableRow DefaultRow { get; set; }
    IiFeatureTableColumns iFeatureTableColumns { get; }
    IiFeatureTableRows iFeatureTableRows { get; }
    object ExcelWorkSheet { get; }
    void Delete();
    void Export(string FileName, FileFormatEnum FileFormat, object Options);
}
