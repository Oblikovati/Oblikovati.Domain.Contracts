using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDocumentSubTypeHandlerEventsSink
{
    void OnChangeType(bool ConvertToSubType, IDocument Document, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
