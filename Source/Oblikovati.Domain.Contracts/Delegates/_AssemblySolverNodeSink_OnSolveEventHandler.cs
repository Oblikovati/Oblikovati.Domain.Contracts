using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void _AssemblySolverNodeSink_OnSolveEventHandler(INameValueMap Context, EventTimingEnum BeforeOrAfter);
