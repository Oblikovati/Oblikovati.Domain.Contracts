using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ModelAnnotations;

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