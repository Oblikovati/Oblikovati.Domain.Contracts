using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Leaders;

public interface ILeaderNode
{
    IAttributeSets AttributeSets { get; }
    IPoint2d Position { get; set; }
    IGeometryIntent AttachedEntity { get; set; }
    ILeaderNodesEnumerator ChildNodes { get; }
    void Delete(bool RetainDependentNodes);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void AddLeader(IObjectCollection Points);
    ILeaderNode InsertNode(ILeaderNode ChildNode, IPoint2d Position);
}