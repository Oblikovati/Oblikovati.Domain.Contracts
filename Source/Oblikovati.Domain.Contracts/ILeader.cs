using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ILeader
{


    IAttributeSets AttributeSets { get; }
    bool HasRootNode { get; }
    ILeaderNode RootNode { get; }
    ILeaderNodesEnumerator AllLeafNodes { get; }
    ILeaderNodesEnumerator AllNodes { get; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void AddLeader(IObjectCollection Points);
}
