﻿using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelAnnotations : IList<IModelAnnotations>
{
    IModelAnnotation Item { get; }
    IModelFeatureControlFrames ModelFeatureControlFrames { get; }
    IModelSurfaceTextureSymbols ModelSurfaceTextureSymbols { get; }
    IModelDimensions ModelDimensions { get; }
    IModelHoleThreadNotes ModelHoleThreadNotes { get; }
    IModelLeaderNotes ModelLeaderNotes { get; }
    IModelDatumIdentifiers ModelDatumIdentifiers { get; }
    IModelCompositeAnnotations ModelCompositeAnnotations { get; }
    IModelGeneralNotes ModelGeneralNotes { get; }

    IAnnotationPlaneDefinitionsEnumerator CreateAnnotationPlaneDefinitionUsingIntents(ObjectTypeEnum AnnotationType,
        IGeometryIntent IntentOne, object IntentTwo, object IntentThree, object XAxis);

    IAnnotationPlaneDefinition CreateAnnotationPlaneDefinitionUsingPlane(object Plane, object XAxisDirection);
}