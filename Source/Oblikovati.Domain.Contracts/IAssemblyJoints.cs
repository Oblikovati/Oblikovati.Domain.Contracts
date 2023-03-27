using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAssemblyJoints : IList<IAssemblyJoints>
{

    int Count { get; }
    IAssemblyJoint Item { get; }
    IEnumerator GetEnumerator();
    IAssemblyJoint Add(IAssemblyJointDefinition AssemblyJointDef);
    IAssemblyJointDefinition CreateAssemblyJointDefinition(AssemblyJointTypeEnum JointType, IGeometryIntent OriginOne, IGeometryIntent OriginTwo);
}
