using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch2D;

public interface IDataIO
{
    void WriteDataToFile(string Format, string FileName);
    void WriteDataToStream(string Format, ref object Stream);
    void ReadDataFromFile(string Format, string FileName);
    void ReadDataFromStream(string Format, object Stream);
    void GetOutputFormats(ref List<string> Formats, ref List<StorageTypeEnum> StorageTypes);
    void GetInputFormats(ref List<string> Formats, ref List<StorageTypeEnum> StorageTypes);
}