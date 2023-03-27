using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void TriadEventsSink_OnTerminate2EventHandler(bool Cancelled, INameValueMap Context, out HandlingCodeEnum HandlingCode);
