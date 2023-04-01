using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.UserInterfaceManager.BalloonTips;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;

public interface IDrawingStylesManager
{
    IDrawingStandardStylesEnumerator StandardStyles { get; }
    IDimensionStylesEnumerator DimensionStyles { get; }
    IDrawingDocument Parent { get; }
    ITextStylesEnumerator TextStyles { get; }
    IDrawingStandardStyle ActiveStandardStyle { get; set; }
    IObjectDefaultsStylesEnumerator ObjectDefaultsStyles { get; }
    ILayersEnumerator Layers { get; }
    IStyles Styles { get; }
    ILeaderStylesEnumerator LeaderStyles { get; }
    IBalloonStylesEnumerator BalloonStyles { get; }
    IFeatureControlFrameStylesEnumerator FeatureControlFrameStyles { get; }
    ISurfaceTextureStylesEnumerator SurfaceTextureStyles { get; }
    IHoleTableStylesEnumerator HoleTableStyles { get; }
    ICentermarkStylesEnumerator CentermarkStyles { get; }
    IPartsListStylesEnumerator PartsListStyles { get; }
    IRevisionTableStylesEnumerator RevisionTableStyles { get; }
    ITableStylesEnumerator TableStyles { get; }
    void ReplaceStyles(IObjectCollection ReplacedStyles, IStyle ReplaceStyle, object PurgeReplacedStyles);
}