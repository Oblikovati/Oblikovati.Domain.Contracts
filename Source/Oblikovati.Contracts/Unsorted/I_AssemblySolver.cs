using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;

namespace Oblikovati.Contracts.Unsorted;

public interface I_AssemblySolver
{
    IAssemblyComponentDefinition Parent { get; }
    I_AssemblySolverNode FindSolverNode(object Object);
}