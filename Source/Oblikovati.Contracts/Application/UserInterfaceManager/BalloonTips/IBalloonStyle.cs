using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.BalloonTips;

public interface IBalloonStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    ILeaderStyle LeaderStyle { get; set; }
    ILeaderStyle AlternateLeaderStyle { get; set; }
    ITextStyle TextStyle { get; set; }
    double DefaultOffset { get; set; }
    BalloonTypeEnum BalloonType { get; set; }
    string Properties { get; set; }
    bool ScaleToTextHeight { get; set; }
    double BalloonDiameter { get; set; }
    bool StretchBalloonToText { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}