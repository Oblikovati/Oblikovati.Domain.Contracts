using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDSJoint
{
    IDynamicSimulation Parent { get; }
    IDSJointDefinition Definition { get; set; }
    string Name { get; set; }
    bool IsSuppressed { get; set; }
    DSJointTypeEnum JointType { get; }
}