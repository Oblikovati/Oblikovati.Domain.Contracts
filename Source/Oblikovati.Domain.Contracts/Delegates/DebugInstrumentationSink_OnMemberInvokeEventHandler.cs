using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void DebugInstrumentationSink_OnMemberInvokeEventHandler(int Cookie, string MemberName, EventTimingEnum BeforeOrAfter, int Result);
