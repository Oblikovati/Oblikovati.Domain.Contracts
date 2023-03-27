namespace Oblikovati.Domain.Contracts;

public interface IFaceDraftFeatures : IList<IFaceDraftFeatures>
{

    IFaceDraftFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IFaceDraftFeature _AddFixedEdge(IFaceCollection Faces, IEdgeCollection FixedEdges, object DraftAngle, object PullDirection, bool DirectionReversed);
    IFaceDraftFeature _AddFixedPlane(IFaceCollection Faces, object DraftAngle, object FixedPlane, bool DirectionReversed);
    IFaceDraftFeature _AddTaperShadow(IFaceCollection Faces, object DraftAngle, object PullDirection, bool DirectionReversed);
    IFaceDraftFeature Add(IFaceDraftDefinition FaceDraftDefinition);
    IFaceDraftDefinition CreateFaceDraftDefinition();
}
