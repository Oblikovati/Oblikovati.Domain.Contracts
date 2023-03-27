using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingEventsSink
{
    void OnRetrieveDimensions(IObjectsEnumerator SketchDimensions, IGeneralDimensionsEnumerator DrawingDimensions, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
