using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingViews : IList<IDrawingViews>
{
    IDrawingView Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IDrawingView AddBaseView(IDocument Model, IPoint2d Position, double Scale, ViewOrientationTypeEnum ViewOrientation, DrawingViewStyleEnum ViewStyle, string ModelViewName, object ArbitraryCamera, object AdditionalOptions);
    IDrawingView _AddProjectedView(IDrawingView ParentView, IPoint2d Position, ViewOrientationTypeEnum ViewOrientation, DrawingViewStyleEnum ViewStyle, object Scale);
    IDrawingView AddProjectedView(IDrawingView ParentView, IPoint2d Position, DrawingViewStyleEnum ViewStyle, object Scale);
    IDrawingView AddAssociativeDraftView(IDocument Model, IPoint2d Position, double Scale, string Name);
    IDrawingView AddDraftView(double Scale, string Name);
    ISectionDrawingView AddSectionView(IDrawingView ParentView, IDrawingSketch SectionLineSketch, IPoint2d Position, DrawingViewStyleEnum ViewStyle, object Scale, bool ShowLabel, string Name, bool Reserved, bool FullDepth, object SectionDepth);
    IDetailDrawingView AddDetailView(IDrawingView ParentView, IPoint2d Position, DrawingViewStyleEnum ViewStyle, bool CircularFence, IPoint2d FenceCenterOrCornerOne, object FenceRadiusOrCornerTwo, object AttachPoint, object Scale, bool ShowLabel, string Name, bool Reserved);
    IDrawingView AddAuxiliaryView(IDrawingView ParentView, IDrawingCurve OrientationEdge, IPoint2d Position, DrawingViewStyleEnum ViewStyle, object Scale, bool ShowLabel, string Name);
    IDrawingView AddOverlayView(IDrawingView ParentView, string PositionalRepresentation, string DesignViewRepresentation, bool DesignViewAssociative, DrawingViewStyleEnum ViewStyle, bool ShowLabel, string Name);
    IDrawingView _AddBaseView(IDocument Model, IPoint2d Position, double Scale, ViewOrientationTypeEnum ViewOrientation, DrawingViewStyleEnum ViewStyle, object ViewFileName, object ViewName, object ArbitraryCamera, object AdditionalOptions);
}
