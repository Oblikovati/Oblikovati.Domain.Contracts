using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts;

public interface ICustomTables : IList<ICustomTables>
{
    ICustomTable Item { get; }


    ICustomTable Add(string Title, IPoint2d PlacementPoint, int NumberOfColumns, int NumberOfRows,
        ref List<string> ColumnTitles, object Contents, object ColumnWidths, object RowHeights, object MoreInfo);

    ITableFormat CreateTableFormat();

    ICustomTable AddBendTable(string SheetMetalFileName, IPoint2d PlacementPoint, string Title, object Columns,
        bool BendIDNumericFormat, string BendIDPrefix);

    ICustomTable AddBendTableWithOptions(string SheetMetalFileName, IPoint2d PlacementPoint, object Options);

    ICustomTable AddConfigurationTable(string ConfigurationFileName, IPoint2d PlacementPoint, string Title,
        object Columns);

    ICustomTable AddExcelTable(string ExcelFileName, IPoint2d PlacementPoint, string Title, string StartCell,
        int ColumnHeaderRow);

    ICustomTable AddCSVTable(string CSVFileName, IPoint2d PlacementPoint, string Title, bool UseFirstRowForHeaders);
}