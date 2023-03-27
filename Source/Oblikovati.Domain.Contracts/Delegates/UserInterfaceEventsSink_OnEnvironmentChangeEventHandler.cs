using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInterfaceEventsSink_OnEnvironmentChangeEventHandler(IEnvironment Environment, EnvironmentStateEnum EnvironmentState, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
