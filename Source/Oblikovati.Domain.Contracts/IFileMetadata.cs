using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
