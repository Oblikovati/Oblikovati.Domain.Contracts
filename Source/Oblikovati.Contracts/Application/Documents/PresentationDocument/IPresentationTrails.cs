namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationTrails : IList<IPresentationTrails>
{
    IPresentationTrail Item { get; }
}