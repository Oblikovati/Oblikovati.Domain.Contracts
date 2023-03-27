using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IModelingEventsSink_Event
{
    void add_OnDelete(ModelingEventsSink_OnDeleteEventHandler handler);
    void remove_OnDelete(ModelingEventsSink_OnDeleteEventHandler handler);
    void add_OnNewFeature(ModelingEventsSink_OnNewFeatureEventHandler handler);
    void remove_OnNewFeature(ModelingEventsSink_OnNewFeatureEventHandler handler);
    void add_OnFeatureChange(ModelingEventsSink_OnFeatureChangeEventHandler handler);
    void remove_OnFeatureChange(ModelingEventsSink_OnFeatureChangeEventHandler handler);
    void add_OnNewParameter(ModelingEventsSink_OnNewParameterEventHandler handler);
    void remove_OnNewParameter(ModelingEventsSink_OnNewParameterEventHandler handler);
    void add_OnParameterChange(ModelingEventsSink_OnParameterChangeEventHandler handler);
    void remove_OnParameterChange(ModelingEventsSink_OnParameterChangeEventHandler handler);
    void add_OnClientFeatureDoubleClick(ModelingEventsSink_OnClientFeatureDoubleClickEventHandler handler);
    void remove_OnClientFeatureDoubleClick(ModelingEventsSink_OnClientFeatureDoubleClickEventHandler handler);
    void add_OnClientFeatureSolve(ModelingEventsSink_OnClientFeatureSolveEventHandler handler);
    void remove_OnClientFeatureSolve(ModelingEventsSink_OnClientFeatureSolveEventHandler handler);
    void add_OnGenerateMember(ModelingEventsSink_OnGenerateMemberEventHandler handler);
    void remove_OnGenerateMember(ModelingEventsSink_OnGenerateMemberEventHandler handler);
    void add_OnPreGenerateMember(ModelingEventsSink_OnPreGenerateMemberEventHandler handler);
    void remove_OnPreGenerateMember(ModelingEventsSink_OnPreGenerateMemberEventHandler handler);
    void add_OnModelAnnotationsSolve(ModelingEventsSink_OnModelAnnotationsSolveEventHandler handler);
    void remove_OnModelAnnotationsSolve(ModelingEventsSink_OnModelAnnotationsSolveEventHandler handler);
    void add_OnGeneralSurfaceProfileGDTSolve(ModelingEventsSink_OnGeneralSurfaceProfileGDTSolveEventHandler handler);
    void remove_OnGeneralSurfaceProfileGDTSolve(ModelingEventsSink_OnGeneralSurfaceProfileGDTSolveEventHandler handler);
    void add_OnModelAnnotationsScaleChange(ModelingEventsSink_OnModelAnnotationsScaleChangeEventHandler handler);
    void remove_OnModelAnnotationsScaleChange(ModelingEventsSink_OnModelAnnotationsScaleChangeEventHandler handler);
    void add_OnGenerateModelStateMember(ModelingEventsSink_OnGenerateModelStateMemberEventHandler handler);
    void remove_OnGenerateModelStateMember(ModelingEventsSink_OnGenerateModelStateMemberEventHandler handler);
}
