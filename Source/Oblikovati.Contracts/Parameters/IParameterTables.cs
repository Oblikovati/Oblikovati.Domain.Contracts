namespace Oblikovati.Contracts.Parameters;

public interface IParameterTables : IList<IParameterTables>
{
    IParameterTable Item { get; }


    IParameterTable AddExcelTable(string ExcelDocument, string StartCell, bool Link);
}