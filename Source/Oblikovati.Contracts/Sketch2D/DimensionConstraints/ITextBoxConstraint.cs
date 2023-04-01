using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch2D.DimensionConstraints;

public interface ITextBoxConstraint
{
    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ITextBox TextBox { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}