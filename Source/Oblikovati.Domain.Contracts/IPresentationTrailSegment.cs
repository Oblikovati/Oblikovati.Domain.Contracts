namespace Oblikovati.Domain.Contracts;

public interface IPresentationTrailSegment
{

    object Geometry { get; }

    bool Visible { get; set; }
}
