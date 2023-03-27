using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMeasureEventsSink
{
    void OnSelectParameter(IParameter Parameter, INameValueMap Context);
    void OnMeasure(MeasureTypeEnum MeasureType, double MeasuredValue, INameValueMap Context);
}
