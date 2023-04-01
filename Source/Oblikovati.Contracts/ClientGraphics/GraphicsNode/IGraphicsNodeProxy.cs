using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.Views;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface IGraphicsNodeProxy : IList<IGraphicsNodeProxy>
{
    IClientGraphics Parent { get; }


    IGraphicsPrimitive Item { get; }
    IGraphicsPrimitive ItemById { get; }
    IBox RangeBox { get; }
    int Id { get; set; }
    IMatrix Transformation { get; set; }
    IRenderStyle RenderStyle { get; set; }
    bool Selectable { get; set; }
    bool Visible { get; set; }
    bool VisibleInActiveEditObject { get; set; }
    IViewList VisibleInViews { get; }
    bool ExcludedFromViewAll { get; set; }
    bool AllowSlicing { get; set; }
    string DisplayName { get; set; }
    bool IsTransparentInPlaceEdit { get; set; }
    double OverrideOpacity { get; set; }
    bool AllowSliceCapping { get; set; }
    IAsset Appearance { get; set; }
    IGraphicsNode NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }

    ILineGraphics AddLineGraphics();
    ILineStripGraphics AddLineStripGraphics();
    IPointGraphics AddPointGraphics();
    ITextGraphics AddTextGraphics();
    ITextGraphics AddScalableTextGraphics();
    ITriangleFanGraphics AddTriangleFanGraphics();
    ITriangleGraphics AddTriangleGraphics();
    ITriangleStripGraphics AddTriangleStripGraphics();
    IFeatureGraphics AddFeatureGraphics(IPartFeature PartFeature);
    ICurveGraphics AddCurveGraphics(object Curve);
    void Delete();
    IGraphicsNode Copy(IMatrix Transformation, int NodeId);
    ISurfaceGraphics AddSurfaceGraphics(object Surfaces);

    void SliceGraphics(bool ApplyCapping, IObjectCollection SlicingPlanes, bool ThreeQuarterSection,
        object RenderStyle);

    void ClearSlice();
    IComponentGraphics AddComponentGraphics(IComponentDefinition ComponentDefinition);
}