using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelHoleThreadNotes : IList<IModelHoleThreadNotes>
{
    IModelHoleThreadNote Item { get; }

    IModelHoleThreadNote Add(IModelHoleThreadNoteDefinition Definition);

    IModelHoleThreadNoteDefinition CreateDefinition(IGeometryIntent Intent,
        IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint LandingPosition);

    IHoleClearanceInfo CreateClearanceInfo(string FastenerStandard, string FastenerType, string FastenerSize,
        object FastenerFitType);
}