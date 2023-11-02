using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.NotClassified;

public interface ILoftRail
{
    bool HasConditions { get; }
    LoftConditionEnum Condition { get; set; }
    IParameter Impact { get; }
    object Rail { get; }
    void Delete();
}