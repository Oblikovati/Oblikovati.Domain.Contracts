namespace Oblikovati.Domain.Contracts;

public interface IMaterials : IList<IMaterials>
{


    IMaterial Item { get; }
    int Count { get; }
    IMaterial Add(string Name, double Density);
    IEnumerator GetEnumerator();
}
