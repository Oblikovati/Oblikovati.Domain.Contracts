using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISheet
{


    string Name { get; set; }
    string InternalName { get; }
    string Revision { get; set; }
    IDrawingViews DrawingViews { get; }
    IDataIO DataIO { get; }
    DrawingSheetSizeEnum Size { get; set; }
    PageOrientationTypeEnum Orientation { get; set; }
    double Height { get; set; }
    double Width { get; set; }
    DrawingSheetStatusBits Status { get; }
    IDrawingSketches Sketches { get; }
    IPartsLists PartsLists { get; }
    IBalloons Balloons { get; }
    bool ExcludeFromCount { get; set; }
    bool ExcludeFromPrinting { get; set; }
    ITitleBlock TitleBlock { get; }
    IBorder Border { get; }
    ICustomTables CustomTables { get; }
    IRevisionTables RevisionTables { get; }
    IHoleTables HoleTables { get; }
    IDrawingNotes DrawingNotes { get; }
    ISketchedSymbols SketchedSymbols { get; }
    IAutoCADBlocks AutoCADBlocks { get; }
    IClientViews ClientViews { get; }
    IClientGraphicsCollection ClientGraphicsCollection { get; }
    IGraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    bool IsModelSpaceSheet { get; }
    IFeatureControlFrames FeatureControlFrames { get; }
    ISurfaceTextureSymbols SurfaceTextureSymbols { get; }
    IAttributeSets AttributeSets { get; }
    IDrawingDimensions DrawingDimensions { get; }
    ICentermarks Centermarks { get; }
    ICenterlines Centerlines { get; }
    string _DisplayName { get; }
    void Activate();
    ITitleBlock AddTitleBlock(object TitleBlockDefinition, object TitleBlockLocation, object PromptStrings);
    IBorder AddBorder(object BorderDefinition, object PromptStrings);
    IDefaultBorder AddDefaultBorder(object HorizontalZoneCount, object HorizontalZoneLabelMode, object VerticalZoneCount, object VerticalZoneLabelMode, object LabelFromBottomRight, object DelimitByLines, object Centermarks, object TopMargin, object BottomMargin, object LeftMargin, object RightMargin, object TextStyle, object TextLayer, object LineLayer);
    ISheet CopyTo(I_DrawingDocument TargetDocument);
    void Delete(bool RetainDependentViews);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IGeometryIntent CreateGeometryIntent(object Geometry, object Intent);
    IObjectsEnumerator FindUsingPoint(IPoint2d PointOnSheet, object ProximityTolerance);
    void Update();
    void ChangeLayer(IObjectCollection Objects, ILayer Layer);
    void _SelectByONK(string ObjectNameKey);
}
