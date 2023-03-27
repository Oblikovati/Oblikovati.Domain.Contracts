using Oblikovati.Domain.Contracts;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ChangeProcessorSink_OnExecuteEventHandler(IDocument Document, INameValueMap Context, ref bool Succeeded);
