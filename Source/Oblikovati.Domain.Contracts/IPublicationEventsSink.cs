using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPublicationEventsSink
{
    void OnModelingDataUpdate(I_PresentationDocument Document, IPublication Publication, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
}
