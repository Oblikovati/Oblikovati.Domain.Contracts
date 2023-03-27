namespace Oblikovati.Domain.Contracts;

public interface IIRxSurfaceBody
{
    IIRxEnumFaceShells FaceShells { get; }
    IIRxEnumFaces Faces { get; }
    IIRxEnumEdges Edges { get; }
    IIRxComponentDefinition ComponentDefinition { get; }
    IIRxBox RangeBox { get; }
    short IsSolid { get; }
    double Volume { get; }
    uint GeometryForm { get; }
    IIRxBox PreciseRangeBox { get; }
}
