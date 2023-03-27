namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ChangeDefinitionSink_OnReplayEventHandler(INameValueMap Context, out IChangeProcessor ResultProcessor);
