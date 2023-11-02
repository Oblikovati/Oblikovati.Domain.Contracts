using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;

public interface IAssemblyJoints : IList<IAssemblyJoints>
{
    IAssemblyJoint Item { get; }

    IAssemblyJoint Add(IAssemblyJointDefinition AssemblyJointDef);

    IAssemblyJointDefinition CreateAssemblyJointDefinition(AssemblyJointTypeEnum JointType, IGeometryIntent OriginOne,
        IGeometryIntent OriginTwo);
}