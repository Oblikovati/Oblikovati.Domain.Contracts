namespace Oblikovati.Domain.Contracts;

public interface IQueryManager
{

    string Query(string Criteria, bool IncludingSubCategories);
}
