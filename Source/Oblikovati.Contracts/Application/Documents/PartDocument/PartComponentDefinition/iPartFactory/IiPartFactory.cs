using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iPartFactory;

public interface IiPartFactory
{
    bool CustomFactory { get; }
    IiPartTableRow DefaultRow { get; set; }
    IiPartTableColumns TableColumns { get; }
    IiPartTableRows TableRows { get; }
    object ExcelWorkSheet { get; }
    string MemberCacheDir { get; }
    MemberEditScopeEnum MemberEditScope { get; set; }
    IFactoryOptions FactoryOptions { get; }
    IiPartTableColumn DisplayStyleColumn { get; set; }
    IiPartTableColumn FileNameColumn { get; set; }
    IiPartTableColumn MaterialColumn { get; set; }
    IiPartMember CreateMember(object Row);
    IiPartMember CreateCustomMember(string FullFileName, object Row, object CustomInput);
    void Delete();
    void Export(string FileName, FileFormatEnum FileFormat, object Options);
}