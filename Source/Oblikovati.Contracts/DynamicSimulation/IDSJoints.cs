namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDSJoints : IList<IDSJoints>
{
    IDSJoint Item { get; }
}