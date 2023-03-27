using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelLeader
{


    IAttributeSets AttributeSets { get; }
    bool HasRootNode { get; }
    IModelLeaderNode RootNode { get; }
    IModelLeaderNodesEnumerator AllLeafNodes { get; }
    IModelLeaderNodesEnumerator AllNodes { get; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void AddLeader(IObjectCollection Points);
}
