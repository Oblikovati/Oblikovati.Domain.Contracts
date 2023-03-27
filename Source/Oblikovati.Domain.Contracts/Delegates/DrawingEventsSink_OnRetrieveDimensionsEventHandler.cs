using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void DrawingEventsSink_OnRetrieveDimensionsEventHandler(IObjectsEnumerator SketchDimensions, IGeneralDimensionsEnumerator DrawingDimensions, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
