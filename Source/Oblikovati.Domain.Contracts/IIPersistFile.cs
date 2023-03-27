namespace Oblikovati.Domain.Contracts;

public interface IIPersistFile : IIPersist
{
    void GetClassID(out Guid pClassID);
    void IsDirty();
    void Load(string pszFileName, uint dwMode);
    void Save(string pszFileName, int fRemember);
    void SaveCompleted(string pszFileName);
    void GetCurFile(out string ppszFileName);
}
