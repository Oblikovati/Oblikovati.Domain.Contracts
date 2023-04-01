using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface IPartsListRow : IList<IPartsListRow>
{
    IPartsList Parent { get; }
    IPartsListCell Item { get; }

    bool Expandable { get; }
    bool Expanded { get; set; }
    bool Visible { get; set; }
    bool Custom { get; }
    bool Ballooned { get; }
    IObjectsEnumerator ReferencedRows { get; }
    double Height { get; set; }
    IReferencedFileDescriptors ReferencedFiles { get; }

    void Remove();
    void Reposition(int TargetIndex, bool InsertBefore);
    void SaveItemOverridesToBOM();
}