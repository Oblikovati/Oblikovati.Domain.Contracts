using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void SearchBoxEventsSink_OnEndSearchEventHandler(INameValueMap SearchResult, out HandlingCodeEnum HandlingCode);
