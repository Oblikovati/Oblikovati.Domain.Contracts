using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelStateEventsSink
{
    void OnDeleteModelState(IDocument Document, object ModelState, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnNewModelState(IDocument Document, IModelState ModelState, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnActivateModelState(IDocument Document, IModelState ModelState, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
