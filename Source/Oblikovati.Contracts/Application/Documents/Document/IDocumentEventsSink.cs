using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IDocumentEventsSink
{
    void OnSave(EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnClose(EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnActivate(EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnDeactivate(EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnChangeSelectSet(EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnChange(CommandTypesEnum ReasonsForChange, EventTiming BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnDelete(object Entity, EventTiming BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}