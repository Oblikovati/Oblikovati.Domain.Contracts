using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.FileManager;

public interface IFileManagerEventsSink
{
    void OnFileDelete(string FullFileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnFileCopy(string SourceFullFileName, string DestinationFullFileName, bool Copy, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}