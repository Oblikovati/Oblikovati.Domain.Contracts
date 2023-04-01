using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IDocumentEventsSink
{
    void OnSave(EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnClose(EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnActivate(EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnDeactivate(EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnChangeSelectSet(EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnChange(CommandTypesEnum ReasonsForChange, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnDelete(object Entity, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}