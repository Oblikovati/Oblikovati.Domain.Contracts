using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPresentationEventsSink
{
    void OnNewPublicationMarkedView(I_PresentationDocument Document, IPublication PublicationObj, IPublicationMarkedView PublicationMarkedViewObj, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnDelete(I_PresentationDocument Document, IPublication PublicationObj, object pEntity, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnStoryboardChange(IPublication PublicationObj, IStoryboard StoryboardObj, CommandTypesEnum ReasonsForChange, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnPublicationDesignViewChange(I_PresentationDocument Document, IPublication PublicationObj, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnPublicationComponentChange(I_PresentationDocument Document, IPublicationComponent PublicationComponent, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnNewPublication(I_PresentationDocument Document, IPublication Publication, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnPublicationModelingDataUpdate(IPublication Publication, CommandTypesEnum ReasonsForChange, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnPublicationNameChange(I_PresentationDocument Document, IPublication PublicationObj, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
