using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelLeaderNoteDefinition
{
    IAnnotationPlane AnnotationPlane { get; set; }
    IAnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    IGeometryIntent Intent { get; set; }
    IModelLeader Leader { get; }
    IModelAnnotation Parent { get; }
    IPoint Position { get; set; }
    IModelAnnotationText Text { get; }
    IModelLeaderNoteDefinition Copy();
}
