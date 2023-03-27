﻿namespace Oblikovati.Domain.Contracts;

public interface IModelCompositeAnnotationDefinition
{
    IModelCompositeAnnotation Parent { get; }
    IModelAnnotationsEnumerator Annotations { get; }
    IModelAnnotation BaseAnnotation { get; }
    void AddAnnotation(IModelAnnotation ModelAnnotation);
    void RemoveAnnotation(IModelAnnotation ModelAnnotation);
    IModelCompositeAnnotationDefinition Copy();
}
