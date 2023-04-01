namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationTasks
{
    IPresentationTask Item { get; }
    IPresentationTask ItemById { get; }
    int NextId { get; }
}