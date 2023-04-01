namespace Oblikovati.Contracts.Parameters;

public interface IDerivedParameterTables : IList<IDerivedParameterTables>
{
    IDerivedParameterTable Item { get; }


    IDerivedParameterTable Add(string FullFileName);
    IDerivedParameterTable Add2(string FullFileName, object ParametersToLink);
}