namespace Oblikovati.Contracts.NotClassified;

public interface IQueryManager
{
    string Query(string Criteria, bool IncludingSubCategories);
}