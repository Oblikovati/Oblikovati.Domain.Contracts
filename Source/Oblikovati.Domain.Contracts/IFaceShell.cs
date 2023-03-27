using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFaceShell
{

    ISurfaceBody Parent { get; }
    IFaces Faces { get; }
    IEdges Edges { get; }
    ISurfaceBody SurfaceBody { get; }
    bool IsClosed { get; }
    bool IsVoid { get; }
    ContainmentEnum IsPointInside { get; }
    IBox RangeBox { get; }
    double Volume { get; }
    IAttributeSets AttributeSets { get; }
    int TransientKey { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
