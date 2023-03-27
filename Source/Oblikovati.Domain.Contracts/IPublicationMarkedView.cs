using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPublicationMarkedView
{

    IPublication Parent { get; }
    bool Associative { get; }
    string Id { get; }
    string DisplayName { get; set; }
    double Time { get; set; }
    bool RequireUpdate { get; }
    IStoryboard AssociativeStoryboard { get; }
    ICamera Camera { get; set; }
    IPublicationTweaks Tweaks { get; }
    IPublicationTrails Trails { get; }
    IPublicationMarkedView Copy(object DisplayName);
    void BreakAssociativity(object StoryboardObjects, out object MarkedViewObjects);
    void Delete();
    void Edit();
    void ExitEdit();
    void SetUpdateDataType(MarkedViewDataTypeEnum MarkedViewDataType);
    void Update();
    void SetVisibility(IObjectCollection PublicationComponents, bool Visible);
    bool GetVisibility(IPublicationComponent PublicationComponent);
    void TransformComponents(IObjectCollection PublicationComponents, IMatrix Transform);
    IMatrix GetComponentTransformation(IPublicationComponent PublicationComponent);
    void SetOpacity(IObjectCollection PublicationComponents, double Opacity);
    double GetOpacity(IPublicationComponent PublicationComponent);
    void Rollback(IPublicationTweak Tweak, object Before);
    void SetAppearance(IObjectCollection PublicationComponents, IAsset pAsset);
}
