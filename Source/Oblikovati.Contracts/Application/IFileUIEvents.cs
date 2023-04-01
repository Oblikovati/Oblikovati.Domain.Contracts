using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IFileUIEvents
{
    /// <summary>
    /// Method that fires the OnPopulateFileMetadata event with the input arguments and returns the values specified in
    /// the event. This method should be called just before showing the file naming dialog to the user.
    /// </summary>
    /// <param name="FileMetadataObjects">Input ObjectsEnumerator that contains FileMetadata objects with the proposed
    /// file names and properties. The input enumerator contains one FileMetadata object for every file being generated.
    /// The properties of the FileMetadata objects can be set to the desired values.</param>
    /// <param name="Formulae">Input String that specifies XML-based formulae for generating file name, display name and
    /// file properties. This can be a null string.</param>
    /// <param name="Context">Input/output NameValueMap object that can be used to determine the context of why the
    /// event fired.</param>
    /// <param name="HandlingCode">Input HandlingCodeEnum that indicates how you are handling the event:* kEventNotHandled:
    /// Oblikovati continues with its standard behavior and displays the file-naming dialog to the end-user.* kEventHandled:
    /// Indicates that the client has specified file names and/or properties for the files and Oblikovati should use these to
    /// display in its dialog to the user.* kEventCanceled: This code is return as a signal that an unexpected failure
    /// has occurred.</param>
    void PopulateFileMetadata(IObjectCollection FileMetadataObjects, string Formulae, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    /// <summary>
    /// The OnFileNewDialog event notifies the client when the end-user executes the New or Create Drawing View command to create a new file.
    /// </summary>
    EventHandler<OnFileNewDialogEventArgs> OnFileNewDialog { get; }

    public struct OnFileNewDialogEventArgs
    {
        /// <summary>
        /// The default template directory as defined in the File tab of the Application Options dialog.
        /// This information can be used by the client in their dialog to allow the end-user to select one of the
        /// standard templates.
        /// </summary>
        public string TemplateDir;

        /// <summary>
        /// The Windows handle of the Oblikovati Application window. If the client displays their own dialog they can use
        /// this to associate their dialog to the Oblikovati window. This results in better behavior between the client
        /// dialog and Oblikovati. For example, the client window will stay on top of Oblikovati and if the Oblikovati window
        /// is collapsed the client dialog will also be collapsed.
        /// </summary>
        public int ParentHWND;

        /// <summary>
        /// The full filename of the file to use as the template when creating the new file. This can be any existing
        /// file and is not restricted to the files within the default template path. This argument must be set if the
        /// HandlingCode is set to kEventHandled.
        /// </summary>
        public string TemplateFileName;

        /// <summary>
        /// Input object that can be used to determine the context of why the event fired. No context information is
        /// provided for this event.
        /// </summary>
        public INameValueMap Context;
    }

    /// <summary>
    /// The OnFileOpenDialog event notifies the client when the end-user executes the Open command to open an existing file.
    /// By responding to this event the client can override Oblikovati's standard behavior of displaying the Open dialog
    /// and provide their own interface to determine the file to open. This notification is only made in cases where the
    /// Open dialog is displayed to allow the end-user to select a file. If the end-user uses the most recently used
    /// list in the File menu to open a file the Open dialog is bypassed and the file is opened directly and because the
    /// Open dialog is not used this notification is not sent.
    /// </summary>
    EventHandler<OnFileOpenDialogEventArgs> OnFileOpenDialog { get; }

    public struct OnFileOpenDialogEventArgs
    {
        public List<string> FileTypes;
        public int ParentHWND;
        public string FileName;
        public INameValueMap Context;
    }

    /// <summary>
    /// The OnFileSaveAsDialog event notifies the client when the end-user executes the Save As or Save Copy As command
    /// to create a new file.
    /// </summary>
    EventHandler<OnFileSaveAsDialogEventArgs> OnFileSaveAsDialog { get; }

    public struct OnFileSaveAsDialogEventArgs
    {
        public List<string> FileTypes;
        public bool SaveCopyAs;
        public int ParentHWND;
        public string FileName;
        public INameValueMap Context;
    }

    /// <summary>
    /// The OnFileInsertNewDialog event notifies the client whenever the end-user executes the Create Component command
    /// within an assembly.
    /// </summary>
    EventHandler<OnFileInsertNewDialogEventArgs> OnFileInsertNewDialog { get; }

    public struct OnFileInsertNewDialogEventArgs
    {
        public string TemplateDir;
        public List<string> FileTypes;
        public IDocument Document;
        public int ParentHWND;
        public string TemplateFileName;
        public string FileName;
        public string RelativeFileName;
        public string LibraryName;
        public List<byte> CustomLogicalName;
        public INameValueMap Context;
    }

    /// <summary>
    /// The OnFileInsertDialog event notifies a client whenever the end-user has executed a command that provides for
    /// the selection and insertion of a document into another document.
    /// </summary>
    EventHandler<OnFileInsertDialogEventArgs> OnFileInsertDialog { get; }

    public struct OnFileInsertDialogEventArgs
    {
        public List<string> FileTypes;
        public IDocument Document;
        public int ParentHWND;
        public string FileName;
        public string RelativeFileName;
        public string LibraryName;
        public List<byte> CustomLogicalName;
        public INameValueMap Context;
    }

    /// <summary>
    /// Fires when a file is selected from the MRU list to open.
    /// </summary>
    EventHandler<OnFileOpenFromMRUEventArgs> OnFileOpenFromMRU { get; }

    public struct OnFileOpenFromMRUEventArgs
    {
        public string FullFileName;
        public INameValueMap Context;
    }

    /// <summary>
    /// Fires before a File New from standard template is executed.
    /// </summary>
    EventHandler<OnFileNewEventArgs> OnFileNew { get; }

    public struct OnFileNewEventArgs
    {
        public DocumentTypeEnum DocumentType;
        public string TemplateFileName;
        public INameValueMap Context;
    }

    /// <summary>
    /// Event that fires when file names and properties are being generated by a command.
    /// </summary>
    EventHandler<OnPopulateFileMetadataEventArgs> OnPopulateFileMetadata { get; }

    public struct OnPopulateFileMetadataEventArgs
    {
        public IObjectsEnumerator FileMetadataObjects;
        public string Formulae;
        public INameValueMap Context;
    }
}