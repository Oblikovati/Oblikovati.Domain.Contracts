namespace Oblikovati.Domain.Contracts;

public interface ISketch3DSettings
{

    IDocument Parent { get; }
    string AutoBendRadius { get; set; }
}
