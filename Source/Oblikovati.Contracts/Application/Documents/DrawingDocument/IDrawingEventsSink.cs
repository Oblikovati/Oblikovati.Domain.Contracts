using Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets.DrawingDimensions;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingEventsSink
{
    void OnRetrieveDimensions(IObjectsEnumerator SketchDimensions, IGeneralDimensionsEnumerator DrawingDimensions,
        EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}