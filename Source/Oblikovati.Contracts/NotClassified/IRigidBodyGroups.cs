namespace Oblikovati.Contracts.NotClassified;

public interface IRigidBodyGroups : IList<IRigidBodyGroups>
{
    IRigidBodyResults Parent { get; }

    IRigidBodyGroup Item { get; }
}