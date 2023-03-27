using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFileDialogEventsSink
{
    void OnOptions(INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
