using Oblikovati.Contracts.Application.Documents.PresentationDocument;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPublicationEventsSink
{
    void OnModelingDataUpdate(IPresentationDocument Document, IPublication Publication, EventTimingEnum BeforeOrAfter,
        out HandlingCodeEnum HandlingCode);
}