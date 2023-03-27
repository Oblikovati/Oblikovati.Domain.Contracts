namespace Oblikovati.Domain.Contracts;

public interface IPartsListRow : IList<IPartsListRow>
{

    IPartsList Parent { get; }
    IPartsListCell Item { get; }
    int Count { get; }
    bool Expandable { get; }
    bool Expanded { get; set; }
    bool Visible { get; set; }
    bool Custom { get; }
    bool Ballooned { get; }
    IObjectsEnumerator ReferencedRows { get; }
    double Height { get; set; }
    IReferencedFileDescriptors ReferencedFiles { get; }
    IEnumerator GetEnumerator();
    void Remove();
    void Reposition(int TargetIndex, bool InsertBefore);
    void SaveItemOverridesToBOM();
}
