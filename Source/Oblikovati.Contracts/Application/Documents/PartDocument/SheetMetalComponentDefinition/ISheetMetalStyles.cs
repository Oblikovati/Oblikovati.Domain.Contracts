namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;

public interface ISheetMetalStyles : IList<ISheetMetalStyles>
{
    ISheetMetalStyle Item { get; }

    ISheetMetalStyle Copy(ISheetMetalStyle ExistingStyle, string NewStyleName);
}