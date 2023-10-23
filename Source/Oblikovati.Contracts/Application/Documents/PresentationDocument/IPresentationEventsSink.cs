using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationEventsSink
{
    void OnNewPublicationMarkedView(IPresentationDocument Document, IPublication PublicationObj,
        IPublicationMarkedView PublicationMarkedViewObj, EventTiming BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnDelete(IPresentationDocument Document, IPublication PublicationObj, object pEntity,
        EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnStoryboardChange(IPublication PublicationObj, IStoryboard StoryboardObj, CommandTypesEnum ReasonsForChange,
        EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnPublicationDesignViewChange(IPresentationDocument Document, IPublication PublicationObj,
        EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnPublicationComponentChange(IPresentationDocument Document, IPublicationComponent PublicationComponent,
        EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnNewPublication(IPresentationDocument Document, IPublication Publication, EventTiming BeforeOrAfter,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnPublicationModelingDataUpdate(IPublication Publication, CommandTypesEnum ReasonsForChange,
        EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnPublicationNameChange(IPresentationDocument Document, IPublication PublicationObj,
        EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}