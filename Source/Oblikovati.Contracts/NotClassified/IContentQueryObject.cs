using Oblikovati.Contracts.Application.ContentCenter;

namespace Oblikovati.Contracts.NotClassified;

public interface IContentQueryObject
{
    IContentCenter Parent { get; }

    void StartActiveQuery(string QueryXML);
    string StartWaitQuery(string QueryXML, bool IncludingSubCategories);
    void Stop();
}