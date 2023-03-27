namespace Oblikovati.Domain.Contracts;

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
