namespace Oblikovati.Domain.Contracts;

public interface IDerivedParameterTables : IList<IDerivedParameterTables>
{
    IDerivedParameterTable Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IDerivedParameterTable Add(string FullFileName);
    IDerivedParameterTable Add2(string FullFileName, object ParametersToLink);
}
