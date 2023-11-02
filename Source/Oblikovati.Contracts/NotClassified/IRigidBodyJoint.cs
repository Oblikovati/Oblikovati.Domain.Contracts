using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.AssemblyConstraints;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IRigidBodyJoint
{
    IRigidBodyJoints Parent { get; }
    IAssemblyConstraintsEnumerator Constraints { get; }
    IAssemblyJointsEnumerator Joints { get; }
    RigidBodyJointTypeEnum JointType { get; }
    IRigidBodyGroup GroupOne { get; }
    IRigidBodyGroup GroupTwo { get; }
    void GetJointData(out object GeometryOne, out object GeometryTwo, out INameValueMap AdditionalInfo);
}