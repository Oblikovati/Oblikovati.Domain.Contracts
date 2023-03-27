namespace Oblikovati.Domain.Contracts;

public interface IProfilePathProxy : IList<IProfilePathProxy>
{

    IProfile Parent { get; }
    int Count { get; }
    IProfileEntity Item { get; }
    bool Closed { get; }
    bool AddsMaterial { get; set; }
    IAttributeSets AttributeSets { get; }
    ITextBox TextBox { get; }
    bool TextBoxPath { get; }
    IProfilePath NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    IEnumerator GetEnumerator();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}
