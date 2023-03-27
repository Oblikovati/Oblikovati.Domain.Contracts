using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ILoftRail
{

    bool HasConditions { get; }
    LoftConditionEnum Condition { get; set; }
    IParameter Impact { get; }
    object Rail { get; }
    void Delete();
}
