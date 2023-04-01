namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IMaterials : IList<IMaterials>
{
    IMaterial Item { get; }

    IMaterial Add(string Name, double Density);
}