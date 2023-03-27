using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface I_AssemblySolverNodeSink
{
    void OnSolve(INameValueMap Context, EventTimingEnum BeforeOrAfter);
}
