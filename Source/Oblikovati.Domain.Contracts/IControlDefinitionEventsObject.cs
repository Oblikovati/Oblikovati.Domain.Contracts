using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IControlDefinitionEventsObject
{
    IControlDefinition Parent { get; }
    void FireOnCommandInputs(EventTimingEnum BeforeOrAfter, INameValueMap Context, out INameValueMap Inputs, out HandlingCodeEnum HandlingCode);
}
