namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationTrailSegment
{
    object Geometry { get; }

    bool Visible { get; set; }
}