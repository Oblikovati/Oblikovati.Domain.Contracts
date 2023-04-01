using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ContentCenter;

public interface IContentFamily
{
    string Description { get; set; }
    string DisplayName { get; set; }
    string MemberDirectory { get; set; }
    bool IsModifiable { get; }
    string Manufacturer { get; set; }
    string Standard { get; set; }
    string StandardOrganization { get; set; }
    string StandardRevision { get; set; }
    IContentTableColumns TableColumns { get; }
    IContentTableRows TableRows { get; }
    string InternalName { get; }
    string ContentIdentifier { get; }
    string LibraryInternalName { get; }
    string LibraryName { get; }
    bool IsCustom { get; }
    ContentFamilyTypeEnum FamilyType { get; }
    IContentTableColumn FileNameColumn { get; }
    string TemplateFileName { get; }
    bool HasiMates { get; }
    string RevisionId { get; }
    IContentTableColumn DesignationColumn { get; }
    IContentTableCell ActiveCell { get; }

    string CreateMember(object Row, out MemberManagerErrorsEnum FailureReason, out string FailureMessage,
        ContentMemberRefreshEnum Refresh, bool Custom, string FileName, object CustomInput, object Options);

    void GetCustomData(string ClientId, string InternalName, out List<byte> CustomData);
    bool HasCustomData(string ClientId, string InternalName);
    void Save();
}