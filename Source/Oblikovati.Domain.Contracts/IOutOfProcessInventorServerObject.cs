namespace Oblikovati.Domain.Contracts;

public interface IOutOfProcessOblikovatiServerObject
{
    IOblikovatiServer OblikovatiServer { get; }
    int ProcessID { get; }
    void RegisterServerObject(int dwFlags, out int pdwRegister);
    void RevokeServerObject(int dwRegister);
    void UnloadServer();
    void SetEnvironmentVariable(string bstrEnvStr);
}
