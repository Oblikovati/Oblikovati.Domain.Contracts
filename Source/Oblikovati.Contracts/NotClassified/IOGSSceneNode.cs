using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

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