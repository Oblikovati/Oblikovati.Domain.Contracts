using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICameraEventsSink
{
    void OnCameraChange(IView View, EventTimingEnum BeforeOrAfter, INameValueMap Context);
}
