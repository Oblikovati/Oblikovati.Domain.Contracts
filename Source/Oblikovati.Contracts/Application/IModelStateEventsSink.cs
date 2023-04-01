using Oblikovati.Contracts.Application.Documents;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IModelStateEventsSink
{
    void OnDeleteModelState(IDocument Document, object ModelState, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnNewModelState(IDocument Document, IModelState ModelState, EventTimingEnum BeforeOrAfter,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnActivateModelState(IDocument Document, IModelState ModelState, EventTimingEnum BeforeOrAfter,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);
}