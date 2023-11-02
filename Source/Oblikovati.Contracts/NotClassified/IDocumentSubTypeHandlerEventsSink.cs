using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IDocumentSubTypeHandlerEventsSink
{
    void OnChangeType(bool ConvertToSubType, IDocument Document, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}