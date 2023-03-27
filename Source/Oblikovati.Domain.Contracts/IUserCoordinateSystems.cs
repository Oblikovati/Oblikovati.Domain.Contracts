namespace Oblikovati.Domain.Contracts;

public interface IUserCoordinateSystems : IList<IUserCoordinateSystems>
{

    int Count { get; }
    IUserCoordinateSystem Item { get; }
    IEnumerator GetEnumerator();
    IUserCoordinateSystem Add(IUserCoordinateSystemDefinition Definition);
    IUserCoordinateSystemDefinition CreateDefinition();
}
