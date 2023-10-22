using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.FileManager;

public interface IFileManager : IInjectableSingletonEntity
{
    IFileManagerEvents FileManagerEvents { get; }
    IFilesEnumerator Files { get; }
    object FileSystemObject { get; }
    void DeleteFile(string FullFileName, FileManagementEnum FileManagementOption);
    void CopyFile(string SourceFullFileName, string DestinationFullFileName, FileManagementEnum FileManagementOption);
    void MoveFile(string SourceFullFileName, string DestinationFullFileName, FileManagementEnum FileManagementOption);

    /// <summary>
    /// Method that specifies the template to use when creating a file.
    /// </summary>
    /// <param name="DocumentType">Input constant that specifies the type of to create.</param>
    /// <param name="SystemOfMeasure">Input constant that specifies the system of measure to use in the drawing being created.</param>
    /// <param name="DraftingStandard">Input constant that specifies the drafting standard to use in the drawing being created.</param>
    /// <param name="DocumentSubType">Input constant (GUID) that specifies the subtype of the document to be created (sheet metal or weldment).</param>
    /// <returns></returns>
    string GetTemplateFile(DocumentType DocumentType, SystemOfMeasureEnum SystemOfMeasure,
        DraftingStandardEnum DraftingStandard, object DocumentSubType);

    void GetIdentifierFromFileName(string FullFileName, ref List<byte> Identifier, string AbsolutePath);
    void GetFileNameFromIdentifier(ref List<byte> Identifier, out string FullFileName, string AbsolutePath);
    string GetFullDocumentName(string FullFileName, string ModelStateName);
    string GetLevelOfDetailName(string FullDocumentName);
    string GetFullFileName(string FullDocumentName);
    List<string> GetDesignViewRepresentations(string FullFileName);
    List<string> GetPositionalRepresentations(string FullFileName);
    List<string> GetLevelOfDetailRepresentations(string FullFileName);
    string GetLastActiveLevelOfDetailRepresentation(string FullFileName);
    bool IsFileNameValid(string FileName, out string ValidFileName);
    List<string> GetDWGDocumentReferences(object DocumentOrFileName);
    bool IsOblikovatiDWG(string FullFileName);
    void RefreshAllDocuments();
    string GetLastActiveDesignViewRepresentation(string FullFileName);
    ISoftwareVersion SoftwareVersionSaved(string FullFileName);
    List<string> GetAutoCADBlockDefinitions(string FullFileName);
    CachedGraphicsStatusEnum GetExpressGraphicsStatus(string AssemblyFullFilename);
    int ReferencedDocumentCount(string FullFileName);
    bool WillOpenExpressDefault(string FullFileName);
    bool CanCADFileBeAssociativelyImported(string FullFileName);
    bool IsOblikovatiComponent(string FullFileName);
    bool IsFutureCADFile(string FullFileName);
    void GetCADFileStructure(string FullFileName, string ResultXML);
    bool IsEmbeddedDocumentPath(string FullFileName);
    string GetEmbeddedDocumentShortName(string FullFileName);
    List<string> GetSHXFontList(object BigFont);
    List<string> GetModelStates(string FullFileName);
    string GetModelStateName(string FullDocumentName);
    string GetLastActiveModelState(string FullFileName);
}