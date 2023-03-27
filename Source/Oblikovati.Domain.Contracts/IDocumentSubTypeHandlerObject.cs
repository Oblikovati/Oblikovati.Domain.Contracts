namespace Oblikovati.Domain.Contracts;

public interface IDocumentSubTypeHandlerObject
{
    string ApplicationName { get; set; }
    IEnvironmentBase DefaultEnvironment { get; }
    string DocumentSubTypeID { get; }
    bool UserChangeable { get; set; }
}
