using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelLeaderNode
{
    IAttributeSets AttributeSets { get; }
    IPoint Position { get; set; }
    IGeometryIntent Intent { get; set; }
    IModelLeaderNodesEnumerator ChildNodes { get; }
    void Delete(bool RetainDependentNodes);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void AddLeader(IObjectCollection Points);
    IModelLeaderNode InsertNode(IModelLeaderNode ChildNode, IPoint Position);
}