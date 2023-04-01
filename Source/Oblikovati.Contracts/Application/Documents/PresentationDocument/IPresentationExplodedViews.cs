namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationExplodedViews : IList<IPresentationExplodedViews>
{
    IPresentationExplodedView Item { get; }
}