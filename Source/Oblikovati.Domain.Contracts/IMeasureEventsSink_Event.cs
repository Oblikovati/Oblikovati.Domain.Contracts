using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IMeasureEventsSink_Event
{
    void add_OnSelectParameter(MeasureEventsSink_OnSelectParameterEventHandler handler);
    void remove_OnSelectParameter(MeasureEventsSink_OnSelectParameterEventHandler handler);
    void add_OnMeasure(MeasureEventsSink_OnMeasureEventHandler handler);
    void remove_OnMeasure(MeasureEventsSink_OnMeasureEventHandler handler);
}
