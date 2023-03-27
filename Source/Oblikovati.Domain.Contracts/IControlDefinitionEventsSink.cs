using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IControlDefinitionEventsSink
{
    void OnCommandInputs(EventTimingEnum BeforeOrAfter, INameValueMap Context, out INameValueMap Inputs, out HandlingCodeEnum HandlingCode);
}
