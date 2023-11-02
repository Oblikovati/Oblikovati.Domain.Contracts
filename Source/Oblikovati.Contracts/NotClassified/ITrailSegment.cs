namespace Oblikovati.Contracts.NotClassified;

public interface ITrailSegment
{
    ITrail Parent { get; }
    bool Linear { get; }
    object Geometry { get; }
    bool Visible { get; }
}