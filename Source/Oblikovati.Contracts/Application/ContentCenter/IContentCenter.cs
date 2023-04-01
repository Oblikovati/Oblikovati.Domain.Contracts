using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ContentCenter;

public interface IContentCenter : IInjectableSingletonEntity
{
    IContentQuery Query { get; }
    string Language { get; set; }
    ICategoryManager CategoryManager { get; }
    IFamilyManager FamilyManager { get; }
    IMemberManager MemberManager { get; }
    IQueryManager QueryManager { get; }
    ILibraryManager LibraryManager { get; }
    IContentCenterEvents ContentCenterEvents { get; }
    IContentTreeViewNode TreeViewTopNode { get; }
    void Refresh(bool Full);
    bool ContentCenterControlled(object Document);
    string GetMoniker(object Document);
    IContentCenterDialog CreateContentCenterDialog();
    object GetTableOfContents(GeneralDataTypeEnum ReturnAs, string LibraryId);
    void ForceRefreshCache();
    object GetOutOfDateParts(IAssemblyDocument Document, bool Recursive);

    bool RefreshStandardComponents(IAssemblyDocument Document, bool Recursive, object Settings,
        object AssemblyRefreshInfo);

    object GetContentObject(string ContentIdentifier, string LibraryId);
}