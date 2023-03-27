using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void AssemblyEventsSink_OnAssemblySolveEventHandler(I_AssemblySolver Solver, EventTimingEnum BeforeOrAfter, INameValueMap Context);
