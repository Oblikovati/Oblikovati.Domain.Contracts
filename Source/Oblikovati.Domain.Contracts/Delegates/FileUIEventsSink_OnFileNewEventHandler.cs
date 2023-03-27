using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileUIEventsSink_OnFileNewEventHandler(DocumentTypeEnum DocumentType, ref string TemplateFileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
