using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFileManagerEventsSink
{
    void OnFileDelete(string FullFileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnFileCopy(string SourceFullFileName, string DestinationFullFileName, bool Copy, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
