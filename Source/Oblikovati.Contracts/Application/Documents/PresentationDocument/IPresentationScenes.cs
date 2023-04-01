namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationScenes : IList<IPresentationScenes>
{
    IPresentationScene Item { get; }
}