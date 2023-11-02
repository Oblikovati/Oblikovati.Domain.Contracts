using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SplitFeature;

public interface ISplitFeatures : IList<ISplitFeatures>
{
    ISplitFeature Item { get; }


    IPath CreatePath(ISketchEntity SketchCurve);
    ISplitFeature SplitPart(object SplitTool, bool RemovePositiveSide);
    ISplitFeature SplitFaces(object SplitTool, bool SplitAll, object FacesOrBody);
    ISplitFeature SplitBody(object SplitTool, ISurfaceBody Body);
    ISplitFeature TrimSolid(object SplitTool, ISurfaceBody Body, bool RemovePositiveSide);
}