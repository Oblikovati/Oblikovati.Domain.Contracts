namespace Oblikovati.Domain.Contracts;

public interface IModelHoleThreadNotes : IList<IModelHoleThreadNotes>
{
    int Count { get; }
    IModelHoleThreadNote Item { get; }
    IEnumerator GetEnumerator();
    IModelHoleThreadNote Add(IModelHoleThreadNoteDefinition Definition);
    IModelHoleThreadNoteDefinition CreateDefinition(IGeometryIntent Intent, IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint LandingPosition);
    IHoleClearanceInfo CreateClearanceInfo(string FastenerStandard, string FastenerType, string FastenerSize, object FastenerFitType);
}
