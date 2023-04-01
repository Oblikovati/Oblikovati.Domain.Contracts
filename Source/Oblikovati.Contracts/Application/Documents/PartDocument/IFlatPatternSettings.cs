using Oblikovati.Contracts.Application.Documents.Document;

namespace Oblikovati.Contracts.Application.Documents.PartDocument;

public interface IFlatPatternSettings
{
    IDocument Parent { get; }
    bool DeferUpdate { get; set; }
}