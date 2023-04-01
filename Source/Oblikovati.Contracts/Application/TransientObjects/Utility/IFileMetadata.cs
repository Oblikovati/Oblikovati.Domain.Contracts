using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransientObjects.Utility;

public interface IFileMetadata
{
    string FullFileName { get; set; }
    string FileName { get; set; }
    bool FileNameOverridden { get; set; }
    string DisplayName { get; set; }
    bool DisplayNameOverridden { get; set; }
    string FileProperties { get; set; }
    IDocument Document { get; set; }
    string TemplateFileName { get; set; }
    BOMStructureEnum BOMStructure { get; set; }
}