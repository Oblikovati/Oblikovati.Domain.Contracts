using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Leaders;

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