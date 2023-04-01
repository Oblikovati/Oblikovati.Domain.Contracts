using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.Views;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface ICameraEvents : IInjectableSingletonEntity
{
    EventHandler<OnCameraChangeEventArgs> OnCameraChange { get; }

    public struct OnCameraChangeEventArgs
    {
        public IView View;
        public EventTimingEnum BeforeOrAfter;
        public INameValueMap Context;
    }
}