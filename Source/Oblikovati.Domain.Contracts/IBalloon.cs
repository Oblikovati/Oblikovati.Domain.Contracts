using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBalloon
{

    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    IBalloonValueSets BalloonValueSets { get; }
    IDrawingView ParentView { get; }
    IPoint2d Position { get; set; }
    BalloonDirectionEnum PlacementDirection { get; set; }
    ILayer Layer { get; set; }
    IBalloonStyle Style { get; set; }
    bool Attached { get; }
    ILeader Leader { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void GetBalloonType(out BalloonTypeEnum BalloonType, out object BalloonTypeData);
    void SetBalloonType(BalloonTypeEnum BalloonType, object BalloonTypeData);
    void SaveItemOverridesToBOM();
}
