namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;

public interface ISheetFormats : IList<ISheetFormats>
{
    ISheetFormat Item { get; }


    ISheetFormat Add(ISheet Sheet, string Name);
    ISheetFormat AddWithOptions(ISheet Sheet, string Name, object Options);
}