using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Unsorted;

public interface I_AssemblySolverNodeSink
{
    void OnSolve(INameValueMap Context, EventTimingEnum BeforeOrAfter);
}