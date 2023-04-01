using Oblikovati.Contracts.ClientGraphics;
using Oblikovati.Contracts.GraphicsDataSets;

namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationScene
{
    IPresentationDocument Parent { get; }
    string Name { get; set; }
    IPresentationSnapshotView ActiveSnapshotView { get; }
    IPresentationSnapshotViews SnapshotViews { get; }
    IPresentationComponent TopSceneComponent { get; }
    bool DesignViewAssociative { get; set; }
    IGraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    IClientGraphicsCollection ClientGraphicsCollection { get; }
    void Activate();
}