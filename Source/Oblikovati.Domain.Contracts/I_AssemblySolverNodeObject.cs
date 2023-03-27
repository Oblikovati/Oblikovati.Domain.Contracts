namespace Oblikovati.Domain.Contracts;

public interface I_AssemblySolverNodeObject
{

    I_AssemblySolver Parent { get; }
    bool SolvedAsRigid { get; set; }
    void AddDependency(I_AssemblySolverNode Node);
}
