using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
