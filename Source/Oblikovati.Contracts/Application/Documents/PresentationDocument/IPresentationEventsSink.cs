using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationEventsSink
{
    void OnNewPublicationMarkedView(IPresentationDocument Document, IPublication PublicationObj,
        IPublicationMarkedView PublicationMarkedViewObj, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnDelete(IPresentationDocument Document, IPublication PublicationObj, object pEntity,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnStoryboardChange(IPublication PublicationObj, IStoryboard StoryboardObj, CommandTypesEnum ReasonsForChange,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnPublicationDesignViewChange(IPresentationDocument Document, IPublication PublicationObj,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnPublicationComponentChange(IPresentationDocument Document, IPublicationComponent PublicationComponent,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnNewPublication(IPresentationDocument Document, IPublication Publication, EventTimingEnum BeforeOrAfter,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnPublicationModelingDataUpdate(IPublication Publication, CommandTypesEnum ReasonsForChange,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnPublicationNameChange(IPresentationDocument Document, IPublication PublicationObj,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}