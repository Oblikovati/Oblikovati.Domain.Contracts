using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelLeaderNotes : IList<IModelLeaderNotes>
{
    IModelLeaderNote Item { get; }


    IModelLeaderNote Add(IModelLeaderNoteDefinition Definition);

    IModelLeaderNoteDefinition CreateDefinition(IObjectCollection LeaderPoints, string FormattedText,
        IAnnotationPlaneDefinition AnnotationPlaneDefinition);
}