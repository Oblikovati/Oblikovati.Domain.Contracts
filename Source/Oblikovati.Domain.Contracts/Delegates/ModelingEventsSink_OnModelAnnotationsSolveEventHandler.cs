using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ModelingEventsSink_OnModelAnnotationsSolveEventHandler(IDocument Document, IModelAnnotations Annotations, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
