using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void SearchBoxEventsSink_OnStopSearchEventHandler(INameValueMap SearchResult, out HandlingCodeEnum HandlingCode);
