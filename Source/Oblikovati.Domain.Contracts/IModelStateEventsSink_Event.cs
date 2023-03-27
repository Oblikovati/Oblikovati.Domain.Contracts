using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IModelStateEventsSink_Event
{
    void add_OnDeleteModelState(ModelStateEventsSink_OnDeleteModelStateEventHandler handler);
    void remove_OnDeleteModelState(ModelStateEventsSink_OnDeleteModelStateEventHandler handler);
    void add_OnNewModelState(ModelStateEventsSink_OnNewModelStateEventHandler handler);
    void remove_OnNewModelState(ModelStateEventsSink_OnNewModelStateEventHandler handler);
    void add_OnActivateModelState(ModelStateEventsSink_OnActivateModelStateEventHandler handler);
    void remove_OnActivateModelState(ModelStateEventsSink_OnActivateModelStateEventHandler handler);
}
