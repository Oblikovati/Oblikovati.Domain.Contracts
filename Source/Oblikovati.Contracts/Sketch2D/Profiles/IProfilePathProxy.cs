using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch2D.Profiles;

public interface IProfilePathProxy : IList<IProfilePathProxy>
{
    IProfile Parent { get; }

    IProfileEntity Item { get; }
    bool Closed { get; }
    bool AddsMaterial { get; set; }
    IAttributeSets AttributeSets { get; }
    ITextBox TextBox { get; }
    bool TextBoxPath { get; }
    IProfilePath NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }

    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}