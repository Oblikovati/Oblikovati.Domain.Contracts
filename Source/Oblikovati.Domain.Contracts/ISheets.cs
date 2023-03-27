using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISheets : IList<ISheets>
{
    ISheet Item { get; }
    int Count { get; }

    IEnumerator GetEnumerator();
    ISheet _Add(ISheet SheetToCopy);
    ISheet Add(DrawingSheetSizeEnum Size, PageOrientationTypeEnum Orientation, string SheetName, object Width, object Height);
    ISheet AddUsingSheetFormat(ISheetFormat SheetFormat, object Model, string SheetName, object AdditionalOptions, object TitleBlockPromptStrings, object BorderPromptStrings);
}
