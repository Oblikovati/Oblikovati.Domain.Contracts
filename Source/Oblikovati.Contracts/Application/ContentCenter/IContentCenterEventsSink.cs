using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ContentCenter;

public interface IContentCenterEventsSink
{
    void OnRefreshStandardComponents(IDocument Document, EventTiming BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}