using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts;

public interface IVertexProxy
{
    ISurfaceBody Parent { get; }
    IEdges Edges { get; }
    IFaces Faces { get; }
    IPoint Point { get; }
    bool IsTolerant { get; }
    double Tolerance { get; }
    IAttributeSets AttributeSets { get; }
    int TransientKey { get; }
    int AssociativeID { get; set; }
    IVertex NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetPoint(ref List<double> Point);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IVertex GetSourceVertex(bool GetLeafSource);
}