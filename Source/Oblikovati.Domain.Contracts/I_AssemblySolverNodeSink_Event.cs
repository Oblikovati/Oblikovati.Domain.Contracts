using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface I_AssemblySolverNodeSink_Event
{
    void add_OnSolve(_AssemblySolverNodeSink_OnSolveEventHandler handler);
    void remove_OnSolve(_AssemblySolverNodeSink_OnSolveEventHandler handler);
}
