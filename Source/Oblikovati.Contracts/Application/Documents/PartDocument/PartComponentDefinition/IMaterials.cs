
namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IMaterials : IList<IMaterial>
{
    IMaterial Add(string Name, double Density);
}