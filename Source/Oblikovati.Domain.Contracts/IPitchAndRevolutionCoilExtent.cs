namespace Oblikovati.Domain.Contracts;

public interface IPitchAndRevolutionCoilExtent
{

    IPartFeature Parent { get; }
    IParameter Pitch { get; }
    IParameter Revolution { get; }
    IParameter TaperAngle { get; }
}
