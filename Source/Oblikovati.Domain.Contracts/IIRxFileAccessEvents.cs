using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxFileAccessEvents
{
    void OnFileResolution(string RelativeFileName, string LibraryName, List<byte> CustomLogicalName, out string FullFileName, out HandlingCodeEnum HandlingCode);
    void OnFileDirty(string RelativeFileName, string LibraryName, List<byte> CustomLogicalName, string FullFileName, IDocument Document, out HandlingCodeEnum HandlingCode);
}
