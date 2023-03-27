namespace Oblikovati.Domain.Contracts;

public interface IModelLeaderNotes : IList<IModelLeaderNotes>
{
    IModelLeaderNote Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IModelLeaderNote Add(IModelLeaderNoteDefinition Definition);
    IModelLeaderNoteDefinition CreateDefinition(IObjectCollection LeaderPoints, string FormattedText, IAnnotationPlaneDefinition AnnotationPlaneDefinition);
}
