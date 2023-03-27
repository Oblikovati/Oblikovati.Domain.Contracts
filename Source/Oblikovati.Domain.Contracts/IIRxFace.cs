namespace Oblikovati.Domain.Contracts;

public interface IIRxFace
{
    IIRxEnumEdgeLoops EdgeLoops { get; }
    IIRxEnumEdges Edges { get; }
    IIRxEnumVertices Vertices { get; }
    IIRxFaceShell FaceShell { get; }
    IIRxSurfaceBody SurfaceBody { get; }
    short IsParamReversed { get; }
    Guid SurfaceType { get; }
    IntPtr Surface { get; }
    uint GeometryForm { get; }
    IIRxSurfaceEvaluator Evaluator { get; }
}
