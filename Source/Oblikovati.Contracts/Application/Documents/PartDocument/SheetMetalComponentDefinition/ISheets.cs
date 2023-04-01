using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;

public interface ISheets : IList<ISheets>
{
    ISheet Item { get; }


    ISheet _Add(ISheet SheetToCopy);

    ISheet Add(DrawingSheetSizeEnum Size, PageOrientationTypeEnum Orientation, string SheetName, object Width,
        object Height);

    ISheet AddUsingSheetFormat(ISheetFormat SheetFormat, object Model, string SheetName, object AdditionalOptions,
        object TitleBlockPromptStrings, object BorderPromptStrings);
}