namespace Oblikovati.Domain.Contracts;

public interface IContentTreeViewNode
{

    IContentTreeViewNodesEnumerator ChildNodes { get; }
    string DisplayName { get; }
    IContentFamiliesEnumerator Families { get; }
    string FullTreeViewPath { get; }
    string InternalName { get; }
    IContentTreeViewNode ParentNode { get; }
}
