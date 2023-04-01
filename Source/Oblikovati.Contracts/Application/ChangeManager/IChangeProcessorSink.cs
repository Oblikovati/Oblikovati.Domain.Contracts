using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.ChangeManager;

public interface IChangeProcessorSink
{
    void OnExecute(IDocument Document, INameValueMap Context, ref bool Succeeded);
    void OnReadFromScript(IDocument Document, string Inputs, INameValueMap Context);
    void OnWriteToScript(IDocument Document, INameValueMap Context, out string ResultInputs);
    void OnTerminate();
}