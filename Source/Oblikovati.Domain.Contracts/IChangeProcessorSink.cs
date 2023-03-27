namespace Oblikovati.Domain.Contracts;

public interface IChangeProcessorSink
{
    void OnExecute(IDocument Document, INameValueMap Context, ref bool Succeeded);
    void OnReadFromScript(IDocument Document, string Inputs, INameValueMap Context);
    void OnWriteToScript(IDocument Document, INameValueMap Context, out string ResultInputs);
    void OnTerminate();
}
