using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch2D.Profiles;

public interface IProfilePath : IList<IProfilePath>
{
    IProfile Parent { get; }

    IProfileEntity Item { get; }
    bool Closed { get; }
    bool AddsMaterial { get; set; }
    IAttributeSets AttributeSets { get; }
    ITextBox TextBox { get; }
    bool TextBoxPath { get; }

    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}