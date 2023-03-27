namespace Oblikovati.Domain.Contracts;

public interface IContentQueryObject
{
    IContentCenter Parent { get; }

    void StartActiveQuery(string QueryXML);
    string StartWaitQuery(string QueryXML, bool IncludingSubCategories);
    void Stop();
}
