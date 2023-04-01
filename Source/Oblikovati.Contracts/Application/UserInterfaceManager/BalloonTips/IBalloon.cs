using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.DrawingView;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Leaders;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.BalloonTips;

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