using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IHoleClearanceInfo
{

    string FastenerStandard { get; set; }
    string FastenerType { get; set; }
    string FastenerSize { get; set; }
    FastenerFitType FastenerFitType { get; set; }

    void SetClearanceInfo(string FastenerStandard, string FastenerType, string FastenerSize, object FastenerFitType);
}
