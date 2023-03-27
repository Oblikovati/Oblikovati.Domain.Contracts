using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void MeasureEventsSink_OnMeasureEventHandler(MeasureTypeEnum MeasureType, double MeasuredValue, INameValueMap Context);
