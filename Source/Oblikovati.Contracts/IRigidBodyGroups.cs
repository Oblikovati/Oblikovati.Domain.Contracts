namespace Oblikovati.Contracts;

public interface IRigidBodyGroups : IList<IRigidBodyGroups>
{
    IRigidBodyResults Parent { get; }

    IRigidBodyGroup Item { get; }
}