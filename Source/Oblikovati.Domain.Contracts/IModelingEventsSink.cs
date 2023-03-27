using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelingEventsSink
{
    void OnDelete(IDocument Document, object Entity, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnNewFeature(IDocument Document, IPartFeature Feature, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnFeatureChange(IDocument Document, IPartFeature Feature, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnNewParameter(IDocument Document, IParameter Parameter, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnParameterChange(IDocument Document, IParameter Parameter, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnClientFeatureDoubleClick(IDocument Document, IClientFeature Feature, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnClientFeatureSolve(IDocument Document, IClientFeature Feature, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnGenerateMember(IDocument FactoryDocument, string MemberName, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnPreGenerateMember(IDocument FactoryDocument, string MemberName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnModelAnnotationsSolve(IDocument Document, IModelAnnotations Annotations, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnGeneralSurfaceProfileGDTSolve(IDocument Document, IModelAnnotation Annotation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnModelAnnotationsScaleChange(IDocument Document, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnGenerateModelStateMember(IDocument FactoryDocument, string MemberName, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
