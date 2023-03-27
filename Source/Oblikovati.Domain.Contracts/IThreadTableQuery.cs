namespace Oblikovati.Domain.Contracts;

public interface IThreadTableQuery
{

    List<string> GetAvailableThreadTypes();
    List<string> GetAvailableThreadSizes(bool Internal, string ThreadType);
    List<string> GetAvailableDesignations(bool Internal, string ThreadType, string NominalSize);
    List<string> GetAvailableClasses(bool Internal, string ThreadType, string ThreadDesignation);
    string GetThreadTypeIdentifier(string ThreadTypeName);
    string GetThreadTypeName(string ThreadTypeIdentifier);
    IThreadInfo CreateThreadInfo(bool Internal, bool RightHanded, string ThreadType, string ThreadDesignation, string Class);
}
