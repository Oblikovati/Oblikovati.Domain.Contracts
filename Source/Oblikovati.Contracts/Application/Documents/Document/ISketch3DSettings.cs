namespace Oblikovati.Contracts.Application.Documents.Document;

public interface ISketch3DSettings
{
    IDocument Parent { get; }
    string AutoBendRadius { get; set; }
}