namespace Oblikovati.Contracts.Application.HelpManager;

public interface IHelpManager : IInjectableSingletonEntity
{
    string HelpPath { get; }
    IHelpEvents HelpEvents { get; }
    void DisplayHelpTopic(string FileName, string TopicName);
    void DisplayHelpContext(string FileName, int Context);
    void RegisterHelpContext(string FileName, int Context, string ContextString);
    string GetOblikovatiHelpURL(string Seed, object Query);
}