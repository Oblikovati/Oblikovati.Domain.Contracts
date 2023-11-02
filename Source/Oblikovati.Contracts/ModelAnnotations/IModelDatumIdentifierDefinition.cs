using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelDatumIdentifierDefinition
{
    IAnnotationPlane AnnotationPlane { get; set; }
    IAnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    string DatumText { get; set; }
    IGeometryIntent Intent { get; set; }
    IModelDatumIdentifier Parent { get; }
    IPoint TextPosition { get; set; }
    IModelDatumIdentifierDefinition Copy();
}