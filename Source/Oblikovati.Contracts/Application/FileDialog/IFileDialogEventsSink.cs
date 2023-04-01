using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.FileDialog;

public interface IFileDialogEventsSink
{
    void OnOptions(INameValueMap Context, out HandlingCodeEnum HandlingCode);
}