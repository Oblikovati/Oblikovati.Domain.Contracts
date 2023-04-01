using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.UserInterfaceManager.Environments;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.UserInterfaceManager;

public interface IUserInterfaceEvents : IInjectableSingletonEntity
{
    /// <summary>
    /// The OnResetEnvironments event notifies the client when environments have been reset.
    /// </summary>
    EventHandler<OnResetEnvironmentsEventArgs>? OnResetEnvironments { get; }

    public struct OnResetEnvironmentsEventArgs
    {
        public IObjectsEnumerator Environments;
        public INameValueMap Context;
    }

    /// <summary>
    /// The OnResetCommandBars event notifies the client when the Command Bars have been reset.
    /// </summary>
    EventHandler<OnResetCommandBarsEventArgs> OnResetCommandBars { get; }

    public struct OnResetCommandBarsEventArgs
    {
        public IObjectsEnumerator CommandBars;
        public INameValueMap Context;
    }

    /// <summary>
    /// The OnEnvironmentChange event notifies the client when the active environment switches from one environment to another.
    /// </summary>
    EventHandler<OnEnvironmentChangeEventArgs> OnEnvironmentChange { get; }

    public struct OnEnvironmentChangeEventArgs
    {
        public IEnvironment Environment;
        public EnvironmentStateEnum EnvironmentState;
        public EventTimingEnum BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Event that is fired when command shortcuts/aliases are reset in the Customize dialog (using either the "Reset All Keys" or "Reset All" button).
    /// </summary>
    EventHandler<OnResetShortcutsEventArgs> OnResetShortcuts { get; }

    public struct OnResetShortcutsEventArgs
    {
        public INameValueMap Context;
    }

    /// <summary>
    /// Event that is fired when the ribbon user interface is reset.
    /// </summary>
    EventHandler<OnResetRibbonInterfaceEventArgs> OnResetRibbonInterface { get; }

    public struct OnResetRibbonInterfaceEventArgs
    {
        public INameValueMap Context;
    }

    /// <summary>
    /// Event that is fired when the user resets an individual or all radial marking menus.
    /// </summary>
    EventHandler<OnResetMarkingMenuEventArgs> OnResetMarkingMenu { get; }

    public struct OnResetMarkingMenuEventArgs
    {
        public string MarkingMenuInternalName;
        public INameValueMap Context;
    }

    /// <summary>
    /// Event that is fired when the Oblikovati layout is reset.
    /// </summary>
    EventHandler<OnResetOblikovatiLayoutEventArgs> OnResetOblikovatiLayout { get; }

    public struct OnResetOblikovatiLayoutEventArgs
    {
        public INameValueMap Context;
    }
}