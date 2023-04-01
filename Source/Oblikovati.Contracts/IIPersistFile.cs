namespace Oblikovati.Contracts;

public interface IIPersistFile : IIPersist
{
    void IsDirty();
    void Load(string pszFileName, uint dwMode);
    void Save(string pszFileName, int fRemember);
    void SaveCompleted(string pszFileName);
    void GetCurFile(out string ppszFileName);
}