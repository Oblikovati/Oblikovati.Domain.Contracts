namespace Oblikovati.Domain.Contracts.Application;

public interface IApplicationLog : IInjectableEntity
{
    void Verbose(string message);
    void Fatal(string message);
    void Error(string message);
    void Debug(string message);
    void Information(string message);
}
