using Oblikovati.Domain.Contracts;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ChangeProcessorSink_OnReadFromScriptEventHandler(IDocument Document, string Inputs, INameValueMap Context);
