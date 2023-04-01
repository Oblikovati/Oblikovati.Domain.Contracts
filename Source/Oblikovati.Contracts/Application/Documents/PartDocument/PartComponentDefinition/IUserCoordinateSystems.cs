namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IUserCoordinateSystems : IList<IUserCoordinateSystems>
{
    IUserCoordinateSystem Item { get; }

    IUserCoordinateSystem Add(IUserCoordinateSystemDefinition Definition);
    IUserCoordinateSystemDefinition CreateDefinition();
}