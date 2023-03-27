using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void CameraEventsSink_OnCameraChangeEventHandler(IView View, EventTimingEnum BeforeOrAfter, INameValueMap Context);
