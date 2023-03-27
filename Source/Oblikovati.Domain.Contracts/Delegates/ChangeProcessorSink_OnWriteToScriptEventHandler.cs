namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ChangeProcessorSink_OnWriteToScriptEventHandler(IDocument Document, INameValueMap Context, out string ResultInputs);
