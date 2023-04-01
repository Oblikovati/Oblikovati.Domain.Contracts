using Oblikovati.Contracts.Application.UserInterfaceManager.BalloonTips;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;

public interface IObjectDefaultsStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    IDimensionStyle AngularDimensionStyle { get; set; }
    IDimensionStyle LinearDimensionStyle { get; set; }
    IDimensionStyle DiameterDimensionStyle { get; set; }
    IDimensionStyle RadialDimensionStyle { get; set; }
    IDimensionStyle BaselineDimensionStyle { get; set; }
    IDimensionStyle OrdinateDimensionStyle { get; set; }
    IDimensionStyle OrdinateSetDimensionStyle { get; set; }
    ITextStyle SketchTextStyle { get; set; }
    IDimensionStyle LeaderTextStyle { get; set; }
    ILayer AngularDimensionLayer { get; set; }
    IBalloonStyle BalloonStyle { get; set; }
    ILayer BalloonLayer { get; set; }
    ILayer BaselineDimensionLayer { get; set; }
    IDimensionStyle BendNoteStyle { get; set; }
    ILayer BendNoteLayer { get; set; }
    ILayer BorderGeometryLayer { get; set; }
    ITextStyle BorderTextStyle { get; set; }
    ILayer BorderTextLayer { get; set; }
    IDimensionStyle ChamferNoteStyle { get; set; }
    ILayer ChamferNoteLayer { get; set; }
    ILayer DiameterDimensionLayer { get; set; }
    IFeatureControlFrameStyle FeatureControlFrameStyle { get; set; }
    ILayer FeatureControlFrameLayer { get; set; }
    IDimensionStyle HoleNoteStyle { get; set; }
    ILayer HoleNoteLayer { get; set; }
    IHoleTableStyle HoleTableStyle { get; set; }
    ILayer HoleTableLayer { get; set; }
    IDimensionStyle HoleTagStyle { get; set; }
    ILayer HoleTagLayer { get; set; }
    ILayer LeaderTextLayer { get; set; }
    ILayer LinearDimensionLayer { get; set; }
    ILayer OrdinateDimensionLayer { get; set; }
    ILayer OrdinateDimensionSetLayer { get; set; }
    ILeaderStyle OriginIndicatorStyle { get; set; }
    ILayer OriginIndicatorLayer { get; set; }
    ILayer PartsListLayer { get; set; }
    IDimensionStyle PunchNoteStyle { get; set; }
    ILayer PunchNoteLayer { get; set; }
    ILayer RadialDimensionLayer { get; set; }
    ILayer SketchGeometryLayer { get; set; }
    ILayer Sketch3DGeometryLayer { get; set; }
    ILayer SketchTextLayer { get; set; }
    ILeaderStyle SketchedSymbolLeaderStyle { get; set; }
    ILayer SketchedSymbolLeaderLayer { get; set; }
    ILayer SketchedSymbolGeometryLayer { get; set; }
    ITextStyle SketchedSymbolTextStyle { get; set; }
    ILayer SketchedSymbolTextLayer { get; set; }
    ISurfaceTextureStyle SurfaceTextureStyle { get; set; }
    ILayer SurfaceTextureLayer { get; set; }
    IDimensionStyle ThreadNoteStyle { get; set; }
    ILayer ThreadNoteLayer { get; set; }
    ILayer TitleBlockGeometryLayer { get; set; }
    ITextStyle TitleBlockTextStyle { get; set; }
    ILayer TitleBlockTextLayer { get; set; }
    ITextStyle GeneralNoteStyle { get; set; }
    ILayer GeneralNoteLayer { get; set; }
    ITextStyle ViewLabelStyle { get; set; }
    ILayer ViewLabelLayer { get; set; }
    ILayer CenterlineLayer { get; set; }
    ICentermarkStyle CenterlineStyle { get; set; }
    ILayer CentermarkLayer { get; set; }
    ICentermarkStyle CentermarkStyle { get; set; }
    ILayer CenterOfGravityLayer { get; set; }
    ICentermarkStyle CenterOfGravityStyle { get; set; }
    ILayer SheetMetalPunchLayer { get; set; }
    ICentermarkStyle SheetMetalPunchStyle { get; set; }
    ILayer WorkAxisLayer { get; set; }
    ICentermarkStyle WorkAxisStyle { get; set; }
    ILayer WorkPlaneLayer { get; set; }
    ICentermarkStyle WorkPlaneStyle { get; set; }
    ILayer WorkPointLayer { get; set; }
    ICentermarkStyle WorkPointStyle { get; set; }
    string _Name { get; set; }
    string _InternalName { get; }
    StyleLocationEnum _StyleLocation { get; }
    bool _InUse { get; }
    bool _UpToDate { get; }
    ILayer ChainDimensionLayer { get; set; }
    IDimensionStyle ChainDimensionStyle { get; set; }
    ILayer BendTableLayer { get; set; }
    ITableStyle BendTableStyle { get; set; }
    ILayer BendTagLayer { get; set; }
    IDimensionStyle BendTagStyle { get; set; }
    ILayer ConfigurationTableLayer { get; set; }
    ITableStyle ConfigurationTableStyle { get; set; }
    IPartsListStyle PartsListStyle { get; set; }
    ILayer RevisionTableLayer { get; set; }
    IRevisionTableStyle RevisionTableStyle { get; set; }
    ILayer RevisionTagLayer { get; set; }
    IRevisionTableStyle RevisionTagStyle { get; set; }
    ILayer TableLayer { get; set; }
    ITableStyle TableStyle { get; set; }
    IObjectDefaultsStyle _Copy(string Name);
    void _Delete();
    IObjectDefaultsStyle _ConvertToLocal();
    void _SaveToGlobal();
    void _UpdateFromGlobal();
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}