using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IAnnotationPlaneDefinition
{
    IAnnotationPlane Parent { get; }
    IPoint Origin { get; }
    ILine XAxis { get; }
    object XAxisEntity { get; set; }
    double XAxisRotation { get; set; }
    IPlane Plane { get; }
    object PlanarEntity { get; }
    IMatrix Transformation { get; }
    IPoint AnnotationPlaneToModel(IPoint2d AnnotationPlaneCoordinate);
    IPoint2d ModelToAnnotationPlane(IPoint ModelCoordinate);
    IAnnotationPlaneDefinition Copy();
}