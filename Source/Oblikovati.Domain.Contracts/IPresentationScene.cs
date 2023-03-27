namespace Oblikovati.Domain.Contracts;

public interface IPresentationScene
{

    I_PresentationDocument Parent { get; }
    string Name { get; set; }
    IPresentationSnapshotView ActiveSnapshotView { get; }
    IPresentationSnapshotViews SnapshotViews { get; }
    IPresentationComponent TopSceneComponent { get; }
    bool DesignViewAssociative { get; set; }
    IGraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    IClientGraphicsCollection ClientGraphicsCollection { get; }
    void Activate();
}
