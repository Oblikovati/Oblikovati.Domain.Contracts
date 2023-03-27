namespace Oblikovati.Domain.Contracts;

public interface IMessageSection
{

    IErrorManager Parent { get; }
    bool HasErrors { get; }
    bool HasWarnings { get; }
    void AdoptMessages(string Message, bool Error, object Reserved);
    void ClearMessages();
    void End();
}
