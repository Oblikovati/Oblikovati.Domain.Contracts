using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IParameterTable
{

    ITableParameters TableParameters { get; }
    bool Linked { get; }
    string FileName { get; set; }
    object WorkSheet { get; }
    string StartCell { get; set; }
    IAttributeSets AttributeSets { get; }
    IReferencedOLEFileDescriptor ReferencedFileDescriptor { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Export(string FileName, FileFormatEnum FileFormat, object Options);
}
