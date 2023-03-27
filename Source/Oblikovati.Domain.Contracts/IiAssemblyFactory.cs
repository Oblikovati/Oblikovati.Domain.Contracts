using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IiAssemblyFactory
{

    IAssemblyComponentDefinition Parent { get; }
    IiAssemblyTableRow DefaultRow { get; set; }
    IiAssemblyTableColumns TableColumns { get; }
    IiAssemblyTableRows TableRows { get; }
    object ExcelWorkSheet { get; }
    string MemberCacheDir { get; }
    MemberEditScopeEnum MemberEditScope { get; set; }
    IFactoryOptions FactoryOptions { get; }
    IiAssemblyTableColumn FileNameColumn { get; set; }
    void Delete();
    void CreateMember(object Row);
    void Export(string FileName, FileFormatEnum FileFormat, object Options);
}
