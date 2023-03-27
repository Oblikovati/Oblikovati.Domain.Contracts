namespace Oblikovati.Domain.Contracts;

public interface IPublication
{

    I_PresentationDocument Parent { get; }
    IPublicationComponents PublicationComponents { get; }
    string DisplayName { get; set; }
    IStoryboard ActiveStoryboard { get; }
    IStoryboards Storyboards { get; }
    double CurrentFrameTime { get; set; }
    IPublicationMarkedViews MarkedViews { get; }
    IGraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    IClientGraphicsCollection ClientGraphicsCollection { get; }
    bool DeferUpdates { get; set; }
    ICamera InitialCamera { get; }
    string InternalName { get; }
    bool InPreviewMode { get; set; }
    bool DesignViewAssociative { get; set; }
    IPublicationComponent TopSceneComponent { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IGeometryIntent CreateGeometryIntent(object Geometry, object Intent);
    void SetActiveStoryboard(IStoryboard Storyboard, object CurrentFrameTime);
    void Activate();
    void Delete();
    object GetClonedEntity(object SourceEntity);
    void SetComponentsOverrideOpacity(IObjectCollection __MIDL__Publication0000, List<double> __MIDL__Publication0001);
    void SetComponentsOverrideVisibility(IObjectCollection __MIDL__Publication0002, bool __MIDL__Publication0003);
    void ClearComponentsOverrideVisibility(IObjectCollection __MIDL__Publication0004);
}
