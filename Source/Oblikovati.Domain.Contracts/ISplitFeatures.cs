namespace Oblikovati.Domain.Contracts;

public interface ISplitFeatures : IList<ISplitFeatures>
{

    ISplitFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IPath CreatePath(ISketchEntity SketchCurve);
    ISplitFeature SplitPart(object SplitTool, bool RemovePositiveSide);
    ISplitFeature SplitFaces(object SplitTool, bool SplitAll, object FacesOrBody);
    ISplitFeature SplitBody(object SplitTool, ISurfaceBody Body);
    ISplitFeature TrimSolid(object SplitTool, ISurfaceBody Body, bool RemovePositiveSide);
}
