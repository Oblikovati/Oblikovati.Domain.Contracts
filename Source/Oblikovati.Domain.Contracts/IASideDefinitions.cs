namespace Oblikovati.Domain.Contracts;

public interface IASideDefinitions : IList<IASideDefinitions>
{

    ISheetMetalComponentDefinition Parent { get; }
    IASideDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IASideDefinition Add(IFace pInput);
}
