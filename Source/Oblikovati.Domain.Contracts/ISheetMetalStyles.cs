namespace Oblikovati.Domain.Contracts;

public interface ISheetMetalStyles : IList<ISheetMetalStyles>
{

    ISheetMetalStyle Item { get; }
    int Count { get; }
    ISheetMetalStyle Copy(ISheetMetalStyle ExistingStyle, string NewStyleName);
    IEnumerator GetEnumerator();
}
