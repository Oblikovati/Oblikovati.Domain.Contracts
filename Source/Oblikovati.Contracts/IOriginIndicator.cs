using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;

namespace Oblikovati.Contracts;

public interface IOriginIndicator
{
    bool Attached { get; }
    bool Visible { get; set; }
    IGeometryIntent Intent { get; set; }
    ILeaderStyle LeaderStyle { get; set; }
    ILayer Layer { get; set; }
    double RelativeX { get; set; }
    double RelativeY { get; set; }
}