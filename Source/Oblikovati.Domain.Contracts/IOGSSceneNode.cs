using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IOGSSceneNode
{

    string Name { get; }
    IOGSRenderItemsEnumerator RenderItems { get; }
    OGSSceneNodeTypeEnum SceneNodeType { get; }
    IMatrix Transformation { get; }
    bool Visible { get; }
    IOGSSceneNodesEnumerator SubSceneNodes { get; }
    IDocument Document { get; }
}
