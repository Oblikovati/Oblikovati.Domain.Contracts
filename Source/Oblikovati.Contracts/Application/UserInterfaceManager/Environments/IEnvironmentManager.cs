using Oblikovati.Contracts.Application.Documents.Document;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.Environments;

public interface IEnvironmentManager
{
    IDocument Parent { get; }
    IEnvironment BaseEnvironment { get; }
    IEnvironment OverrideEnvironment { get; set; }
    IEnvironment EditObjectEnvironment { get; }
    void GetCurrentEnvironment(out IEnvironment Environment, out string EditTargetId);
    void SetCurrentEnvironment(IEnvironment Environment, string EditObjectId);
}