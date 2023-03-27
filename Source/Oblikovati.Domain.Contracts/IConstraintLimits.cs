namespace Oblikovati.Domain.Contracts;

public interface IConstraintLimits
{

    IParameter Maximum { get; }
    bool MaximumEnabled { get; set; }
    IParameter Minimum { get; }
    bool MinimumEnabled { get; set; }

    bool RestingPositionEnabled { get; set; }
}
