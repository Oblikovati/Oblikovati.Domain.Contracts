namespace Oblikovati.Domain.Contracts;

public interface I_AssemblySolver
{

    IAssemblyComponentDefinition Parent { get; }
    I_AssemblySolverNode FindSolverNode(object Object);
}
