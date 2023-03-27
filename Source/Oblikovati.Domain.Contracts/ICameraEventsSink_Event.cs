using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface ICameraEventsSink_Event
{
    void add_OnCameraChange(CameraEventsSink_OnCameraChangeEventHandler handler);
    void remove_OnCameraChange(CameraEventsSink_OnCameraChangeEventHandler handler);
}
