using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IDocumentSubTypeHandlerEventsSink_Event
{
    void add_OnChangeType(DocumentSubTypeHandlerEventsSink_OnChangeTypeEventHandler handler);
    void remove_OnChangeType(DocumentSubTypeHandlerEventsSink_OnChangeTypeEventHandler handler);
}
