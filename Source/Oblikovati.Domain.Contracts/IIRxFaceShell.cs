namespace Oblikovati.Domain.Contracts;

public interface IIRxFaceShell
{
    IIRxEnumFaces Faces { get; }
    IIRxEnumEdges Edges { get; }
    IIRxSurfaceBody SurfaceBody { get; }
    short IsClosed { get; }
    short IsVoid { get; }
    short IsPointInside { get; }
    IIRxBox RangeBox { get; }
    double Volume { get; }
}
