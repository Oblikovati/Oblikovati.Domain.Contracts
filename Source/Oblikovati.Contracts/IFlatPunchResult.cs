using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts;

public interface IFlatPunchResult
{
    IFlatPattern Parent { get; }
    string InternalName { get; }
    IFaces Faces { get; }
    IEdges SketchRepresentationEdges { get; }
    string PunchId { get; }
    bool IsDirectionUp { get; }
    IPoint Position { get; }
    double Angle { get; }
    bool HasDepth { get; }
    double Depth { get; }
    IPoint FoldedPosition { get; }
    double FoldedAngle { get; }
    bool IsPunchSuppressed { get; }
    bool IsPunchAfterStopNode { get; }
}