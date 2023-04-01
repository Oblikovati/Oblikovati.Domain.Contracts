using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;

namespace Oblikovati.Contracts;

public interface IRigidBodyResults
{
    IAssemblyComponentDefinition Parent { get; }
    IRigidBodyGroups RigidBodyGroups { get; }
    IRigidBodyJoints RigidBodyJoints { get; }
}