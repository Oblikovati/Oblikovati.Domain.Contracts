using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ChangeManager;

public interface IChangeProcessorObject
{
    IChangeDefinition Parent { get; }
    bool DisplayMessages { get; set; }
    bool GlobalChangeProcess { get; set; }
    bool GlobalChangeProcessAborted { get; }
    bool Transact { get; set; }
    bool MergeWithPrevious { get; set; }
    CommandTypesEnum ChangeType { get; set; }
    bool DeferDrawingCleanUp { get; set; }
    ButtonTypeEnum MessageDialogUserChoice { get; }
    void Execute(IDocument Document);
    void SetAffectedDocuments(List<string> FullDocumentNames, object ReasonsForChange);
    void SetMessageDialogOptions(bool AllowAccept, bool AllowEdit);
    void _TransactBRepHistory();
}