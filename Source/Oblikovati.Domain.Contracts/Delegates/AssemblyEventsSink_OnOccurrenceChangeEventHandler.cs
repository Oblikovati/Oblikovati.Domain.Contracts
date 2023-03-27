using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void AssemblyEventsSink_OnOccurrenceChangeEventHandler(I_AssemblyDocument Document, IComponentOccurrence Occurrence, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
