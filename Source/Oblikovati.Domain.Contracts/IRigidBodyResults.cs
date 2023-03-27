namespace Oblikovati.Domain.Contracts;

public interface IRigidBodyResults
{

    IAssemblyComponentDefinition Parent { get; }
    IRigidBodyGroups RigidBodyGroups { get; }
    IRigidBodyJoints RigidBodyJoints { get; }
}
