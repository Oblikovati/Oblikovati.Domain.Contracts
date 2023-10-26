using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IFileAccessEvents : IInjectableSingletonEntity
{
    public struct OnFileResolutionEventArgs
    {
        public string RelativeFileName;
        public string LibraryName;
        public EventTiming BeforeOrAfter;
        public string FullFileName;

    }
    public EventHandler<OnFileResolutionEventArgs> OnFileResolution { get; set; }
    
    public struct OnFileDirtyEventArgs
    {
        private string RelativeFileName;
        private string LibraryName;
        private string FullFileName;
        private IDocument Document;
        private EventTiming BeforeOrAfter;
    }

    public EventHandler<OnFileDirtyEventArgs> OnFileDirty { get; set; }
}