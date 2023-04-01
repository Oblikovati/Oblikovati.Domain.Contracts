using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ModelAnnotations;

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