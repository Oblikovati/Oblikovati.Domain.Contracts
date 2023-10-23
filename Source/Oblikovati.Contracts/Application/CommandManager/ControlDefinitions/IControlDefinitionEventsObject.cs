using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;

public interface IControlDefinitionEventsObject
{
    IControlDefinition Parent { get; }

    void FireOnCommandInputs(EventTiming BeforeOrAfter, INameValueMap Context, out INameValueMap Inputs,
        out HandlingCodeEnum HandlingCode);
}