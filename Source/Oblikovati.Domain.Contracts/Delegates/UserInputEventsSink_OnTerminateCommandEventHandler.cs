using Oblikovati.Domain.Contracts;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnTerminateCommandEventHandler(string CommandName, INameValueMap Context);
