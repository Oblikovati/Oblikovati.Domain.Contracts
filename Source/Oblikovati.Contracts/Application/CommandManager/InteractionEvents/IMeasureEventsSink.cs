using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents;

public interface IMeasureEventsSink
{
    void OnSelectParameter(IParameter Parameter, INameValueMap Context);
    void OnMeasure(MeasureTypeEnum MeasureType, double MeasuredValue, INameValueMap Context);
}