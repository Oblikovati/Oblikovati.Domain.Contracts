namespace Oblikovati.Domain.Contracts;

public interface IProfilePath : IList<IProfilePath>
{

    IProfile Parent { get; }
    int Count { get; }
    IProfileEntity Item { get; }
    bool Closed { get; }
    bool AddsMaterial { get; set; }
    IAttributeSets AttributeSets { get; }
    ITextBox TextBox { get; }
    bool TextBoxPath { get; }
    IEnumerator GetEnumerator();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}
