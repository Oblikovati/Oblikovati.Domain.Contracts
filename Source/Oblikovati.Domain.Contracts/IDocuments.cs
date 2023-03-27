using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDocuments : IDocumentsEnumerator, IInjectableSingletonEntity
{
    IDocumentsEnumerator VisibleDocuments { get; }
    int LoadedCount { get; }
    IDocument Add(DocumentTypeEnum DocumentType, string TemplateFileName, bool CreateVisible = true);
    IDocument Open(string FullDocumentName, bool OpenVisible = true);
    IDocument OpenWithOptions(string FullDocumentName, INameValueMap Options, bool OpenVisible = true);
    void CloseAll(bool UnreferencedOnly);
}
