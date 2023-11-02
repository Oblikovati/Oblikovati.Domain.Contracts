using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.Documents.DrawingDocument;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics;
using Oblikovati.Contracts.ClientGraphics.DrawingView;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.GraphicsDataSets;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.NotClassified;

public interface IDetailDrawingView
{
    ISheet Parent { get; }
    DrawingViewTypeEnum ViewType { get; }
    string Name { get; set; }
    DrawingViewStyleEnum ViewStyle { get; set; }
    double Scale { get; set; }
    IPoint2d Center { get; set; }
    IPoint2d Position { get; set; }
    double Top { get; }
    double Left { get; }
    double Height { get; }
    double Width { get; }
    IDataIO DataIO { get; }
    bool BitmapAvailable { get; }
    ICamera Camera { get; }
    IDrawingSketches Sketches { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    IMatrix DrawingViewToModelTransform { get; }
    IMatrix DrawingViewToSheetTransform { get; }
    IMatrix ModelToDrawingViewTransform { get; }
    IMatrix ModelToSheetTransform { get; }
    IDrawingView ParentView { get; }
    IMatrix SheetToModelTransform { get; }
    IMatrix SheetToDrawingViewTransform { get; }
    IClientGraphicsCollection ClientGraphicsCollection { get; }
    IGraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    bool ScaleFromBase { get; set; }
    IDrawingCurvesEnumerator DrawingCurves { get; }
    string ActivePositionalRepresentation { get; set; }
    string ActiveDesignViewRepresentation { get; }
    string ActiveLevelOfDetailRepresentation { get; set; }
    string ActiveMemberName { get; set; }
    IDrawingViewEvents DrawingViewEvents { get; }
    bool ShowScale { get; set; }
    bool ShowName { get; set; }
    IAttributeSets AttributeSets { get; }
    bool DisplayTangentEdges { get; set; }
    bool UpToDate { get; }
    string ScaleString { get; set; }
    double Rotation { get; set; }
    bool IsFlatPatternView { get; }
    GeneralDimensionTypeEnum GeneralDimensionType { get; set; }
    bool Suppressed { get; set; }
    IDrawingViewLabel Label { get; }
    bool HasOriginIndicator { get; }
    IOriginIndicator OriginIndicator { get; }
    bool ShowLabel { get; set; }
    string ActivePresentationView { get; }
    bool Aligned { get; set; }
    IDrawingCurve AuxiliaryOrientationEdge { get; }
    bool DisplayBendExtents { get; set; }
    bool DisplayDefinitionInBase { get; set; }
    bool DisplayHatching { get; set; }
    bool DisplayInterferenceEdges { get; set; }
    bool DisplayForeshortenedTangentEdges { get; set; }
    bool DisplayThreadFeatures { get; set; }
    bool DisplayTrails { get; set; }
    bool InheritBreak { get; set; }
    bool InheritBreakOut { get; set; }
    bool InheritSection { get; set; }
    bool InheritSlice { get; set; }
    bool PresentationViewAssociative { get; set; }
    StandardPartsSectionBehaviorEnum StandardPartsSectionBehavior { get; set; }
    ViewJustificationEnum ViewJustification { get; set; }
    IBreakOperations BreakOperations { get; }
    IBreakOutOperations BreakOutOperations { get; }
    IReferencedFileDescriptor ReferencedFile { get; }
    IPoint2d _Center { get; set; }
    bool ViewOrientationFromBase { get; set; }
    bool IsUpdateComplete { get; }
    bool IsRasterView { get; set; }
    bool IncludeMeshBodies { get; set; }
    bool IncludeSurfaceBodies { get; set; }
    bool DesignViewAssociative { get; }
    string DesignViewRepresentation { get; }
    IDrawingViewHatchRegions HatchRegions { get; }
    string ActiveModelState { get; }
    bool Include3DAnnotations { get; set; }
    bool CircularFence { get; }
    IPoint2d FenceCenter { get; set; }
    double FenceRadius { get; set; }
    IPoint2d FenceCornerOne { get; set; }
    IPoint2d FenceCornerTwo { get; set; }
    IGeometryIntent AttachPoint { get; set; }
    ILayer BoundaryLayer { get; set; }
    bool IsBreakLineSmooth { get; set; }
    bool DisplayFullBoundary { get; set; }
    bool DisplayConnectionLine { get; set; }
    HiddenLinesStatusEnum GetHiddenLinesStatus(object Component);
    void SetHiddenLinesStatus(object Component, HiddenLinesStatusEnum visibleStatus);
    void SetActiveModelState(string ModelState, bool UpdatePartsList, bool KeepOverrides);
    void Delete();
    IDrawingView MoveTo(ISheet TargetSheet);
    IDrawingView CopyTo(ISheet TargetSheet);
    ILine DrawingViewToModelSpace(IPoint2d ViewCoordinate);
    IPoint2d DrawingViewToSheetSpace(IPoint2d ViewCoordinate);
    IPoint2d ModelToDrawingViewSpace(IPoint ModelCoordinate);
    IPoint2d ModelToSheetSpace(IPoint ModelCoordinate);
    ILine SheetToModelSpace(IPoint2d SheetCoordinate);
    IPoint2d SheetToDrawingViewSpace(IPoint2d SheetCoordinate);
    void RotateByAngle(double Angle, bool Clockwise);
    bool GetVisibility(object Object);
    void SetVisibility(bool Visible);
    bool GetIncludeStatus(object Object);
    void SetIncludeStatus(bool Include);
    void ShowHiddenCurves();
    void ShowHiddenAnnotations();
    void SetDesignViewRepresentation(string Representation, bool Associative);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void CreateOriginIndicator(IGeometryIntent Intent);
    void Align(IDrawingView DrawingView, DrawingViewAlignmentEnum AlignmentType);
    void AlignAuxiliary(IDrawingCurve DrawingCurve, IPoint2d Position);
    void GetWeldmentState(out WeldmentStateEnum WeldmentState, out object Component);
    void SetWeldmentState(WeldmentStateEnum WeldmentState, object Component);
    void GetAutomatedCenterlineSettings(out IAutomatedCenterlineSettings AutomatedCenterlineSettings);
    IObjectsEnumerator SetAutomatedCenterlineSettings(object AutomatedCenterlineSettings);
    void _Update();
    void InsertInModelSpace();
}