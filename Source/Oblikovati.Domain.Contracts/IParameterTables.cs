namespace Oblikovati.Domain.Contracts;

public interface IParameterTables : IList<IParameterTables>
{
    IParameterTable Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IParameterTable AddExcelTable(string ExcelDocument, string StartCell, bool Link);
}
