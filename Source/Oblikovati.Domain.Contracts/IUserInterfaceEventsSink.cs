using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IUserInterfaceEventsSink
{
    void OnResetEnvironments(IObjectsEnumerator Environments, INameValueMap Context);
    void OnResetCommandBars(IObjectsEnumerator CommandBars, INameValueMap Context);
    void OnEnvironmentChange(IEnvironment Environment, EnvironmentStateEnum EnvironmentState, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnResetShortcuts(INameValueMap Context);
    void OnResetRibbonInterface(INameValueMap Context);
    void OnResetMarkingMenu(string MarkingMenuInternalName, INameValueMap Context);
    void OnResetOblikovatiLayout(INameValueMap Context);
}
